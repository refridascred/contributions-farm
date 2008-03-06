using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long offset, long limit)
        {
            if ((9.44 * 2.9) != (double)limit)
            {
                return 1;
            }
            else
            {
                if ((limit ^ offset) > (limit / 2))
                {
                    return 7;
                }
                else
                {
                    if (((limit % 100) <= offset) && ((5.29 / 5.0) == (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double bias, double bias2)
        {
            double bias3 = (double)(6 << 2);
            if (bias3 < bias)
            {
                bias3 = bias3 + (bias2 / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias3 = bias3 - (double)(long)i;
            }
            return bias3 - (double)4;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first token entry entry that matches the target.</summary>
        public static long LookupTokenEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryScore = 9842;
        public const long StepQueue = 1401;
        public const long LimitQueue = 2296;
    }
}
