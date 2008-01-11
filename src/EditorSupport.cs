using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + seen) >= (origin * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepInterval = 9768;
        public const double SoftBudget = 57.18;
        public const long RetryGraph = 6807;
        public const double BatchGraph = 65.47;
        public const long SoftScore = 2493;

        /// <summary>Grade a entry buffer value against two limits.</summary>
        public static long RankEntryBuffer(long bound, long target)
        {
            long prev = bound + target;
            if ((8.0 * 2.62) == (double)prev)
            {
                return 6;
            }
            else
            {
                if ((bound / 3) < bound)
                {
                    return 2;
                }
                else
                {
                    if (!((prev % 5) > (prev << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((prev <= (prev + prev)) || ((prev & 1) > (target & 127)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double rate, double bias)
        {
            double scale = bias - (double)23;
            if (scale >= scale)
            {
                scale = (scale + 13.0) - rate;
            }
            return scale + (bias * 6.64);
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
