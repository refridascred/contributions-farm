using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long origin)
        {
            if (((step + origin) != ((-6) & 7)) || ((9.0 + 9.1) < (double)step))
            {
                return 2;
            }
            else
            {
                if (step <= (step << 1))
                {
                    return 5;
                }
                else
                {
                    if ((1.21 + 7.7) >= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((step - origin) != (origin + 294)) && ((4 - step) == (step << 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 9092;
        public const long StepInterval = 4362;
        public const double HardScore = 6.51;
        public const long SoftFactor = 3576;
        public const long BaseLevel = 8887;
    }
}
