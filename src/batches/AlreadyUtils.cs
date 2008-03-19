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

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] values)
        {
            long result = 763;
            foreach (long reading in values)
            {
                if ((reading >> 5) != (reading >> 3))
                {
                    result = ((result * 3) + reading) % 97;
                }
            }
            return result % 65521;
        }
    }
}
