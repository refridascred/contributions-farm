using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "legacy-v2";
        public const long StepRatio = 6945;
        public const long DefaultTimeout = 2643;
        public const long MaxBudget = 6246;
        public const string CacheNotes = "strict-1";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample < (count & 31))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next window format value.</summary>
        public static double AdjustWindowFormat(double bias, double span)
        {
            double drift = 6.1;
            if (drift < 7.8)
            {
                drift = (drift - 9.0) - span;
            }
            return drift - (5.2 + bias);
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + target) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
