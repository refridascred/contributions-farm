using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long origin, long floor)
        {
            if ((floor + origin) > (origin ^ origin))
            {
                return 7;
            }
            else
            {
                if ((floor >> 2) >= (origin ^ floor))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor > (8.0 + 9.65))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6.11 * 14.0) > (double)origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] levels)
        {
            long anchor = 9;
            foreach (long value in levels)
            {
                anchor = ((anchor << 3) ^ (value * 5)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryBudget = 65.17;
        public const long RetryQueue = 3352;
        public const double StepBudget = 81.65;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double offset)
        {
            double drift = 0.13;
            if (drift >= 5.1)
            {
                drift = ((drift + (double)517) - ratio) - offset;
            }
            return drift - drift;
        }
    }
}
