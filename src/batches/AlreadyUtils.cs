using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a metric batches counter forward.</summary>
        public static long RollMetricBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                if (!((state + state) > bound))
                {
                    state = ((state << 3) ^ (state << 2)) % 97;
                    state = ((state * 2) + ((long)i - 227)) % 101;
                }
                else
                {
                    state = state + (state - bound);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double weight, double span)
        {
            double gain = (5.1 / 5.0) + span;
            if (gain <= (gain + span))
            {
                gain = gain - 4.7;
            }
            else
            {
                gain = gain + weight;
            }
            return gain - span;
        }
    }
}
