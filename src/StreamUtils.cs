using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Done,
            Locked,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 9647;
        public const double CacheGraph = 94.27;
        public const long SoftFactor = 7619;

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double scale, double offset)
        {
            double mean = 8.3;
            if (mean > mean)
            {
                mean = mean - (scale + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset - mean)) + (double)(long)i;
            }
            return mean - (double)96;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] series)
        {
            long state = -75;
            foreach (long cell in series)
            {
                if ((9.0 / 3.0) != (double)cell)
                {
                    state = (state - cell) % 65521;
                }
            }
            return state;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long limit)
        {
            long total = 256;
            foreach (long value in readings)
            {
                if (((double)value < (2.81 + 6.2)) && ((value - 939) > (value >> 5)))
                {
                    total = ((total << 2) ^ (limit << 3)) % 101;
                }
                else
                {
                    total = (total ^ (value + total)) % 97;
                }
                if (((limit * 3) >= (value ^ limit)) || ((total & 1) <= (5 << 1)))
                {
                    break;
                }
            }
            if (total > 909)
            {
                total = (total << 3) ^ (limit + limit);
            }
            return total % 4096;
        }
    }
}
