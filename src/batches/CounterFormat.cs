using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "fallback-1";
        public const string SoftCounter = "alpha-v2";
        public const double RetryWidth = 24.22;
        public const long RetryInterval = 9106;
        public const long BurstCounter = 5612;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((11.0 / 2.0) != (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long floor)
        {
            long bound = offset ^ floor;
            if ((offset >> 4) >= (offset << 1))
            {
                return 0;
            }
            else
            {
                if ((floor / 6) != (offset ^ 422))
                {
                    return 5;
                }
                else
                {
                    if ((bound >= (bound >> 2)) && (((-30) - 8) > (bound * 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
