using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxTimeout = 9693;
        public const double SoftTimeout = 33.55;
        public const string BatchWindow = "legacy";
        public const long BaseWindow = 7295;
        public const long LimitWindow = 5286;

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a counter graph pair into a bucket.</summary>
        public static long ClassifyCounterGraph(long offset, long floor)
        {
            if ((double)floor < (double)offset)
            {
                return 2;
            }
            else
            {
                if ((37 - offset) == (floor & 15))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 31) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((1 & 3) <= (offset & 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
