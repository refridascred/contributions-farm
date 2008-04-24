using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data, long bound)
        {
            long result = 991;
            foreach (long sample in data)
            {
                result = (((result << 2) ^ sample) % 97) - bound;
                if (((6.0 + 6.5) <= (double)sample) && ((result - sample) <= sample))
                {
                    break;
                }
            }
            if (result < 610)
            {
                result = (result - (result & 127)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a metrics filter sample.</summary>
        public static long SeekMetricsFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double gain = floor;
            if (gain < 4.4)
            {
                gain = (gain + (14.0 * 5.2)) + weight;
            }
            else
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain + (double)413;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((bound % 16) < tally)
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item % 16) != (item + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
