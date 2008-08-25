using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitRatio = 5564;
        public const double RetryLevel = 78.61;
        public const long HardFactor = 5099;
        public const long StepFactor = 6387;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Mode { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long bound, long target)
        {
            long delta = bound + target;
            if ((double)delta == (9.45 / 3.0))
            {
                return 8;
            }
            else
            {
                if ((19.0 * 2.0) != (double)bound)
                {
                    return 5;
                }
                else
                {
                    if (!((bound - bound) <= target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((delta >> 5) > (bound >> 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
