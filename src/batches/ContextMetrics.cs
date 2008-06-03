using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of entry context readings.</summary>
        public static long MatchEntryContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] levels)
        {
            long anchor = 615;
            foreach (long value in levels)
            {
                anchor = ((anchor * 5) + (value + value)) % 101;
                if (((value << 3) <= (value << 1)) || ((anchor % 60) >= value))
                {
                    anchor = ((anchor << 3) ^ value) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double gain, double bias)
        {
            double gain2 = (double)32 * 4.18;
            if (gain2 <= (gain2 - gain))
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - bias) + (double)(long)i;
            }
            return gain2 + (double)7;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long bound, long target)
        {
            if ((3.0 / 8.0) <= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((target + bound) <= (bound << 3))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 4828;
        public const long BatchSize = 5803;
        public const long HardFactor = 2159;
        public const long BatchBudget = 6278;
    }
}
