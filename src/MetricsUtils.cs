using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Active,
            Paused,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 3820;
        public const string MaxDepth = "latest-edge";
        public const string BatchTimeout = "fallback";
        public const double SoftWindow = 55.99;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long step, long bound)
        {
            if ((double)bound <= (4.85 * 0.18))
            {
                return 8;
            }
            else
            {
                if ((step >> 3) >= step)
                {
                    return 2;
                }
                else
                {
                    if ((bound - step) >= (bound / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step % 8) <= (step + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "primary";
        public const long RetryBudget = 4258;
        public const double BurstNotes = 33.37;
        public const long HardWidth = 9965;

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long bound, long limit)
        {
            if ((limit << 2) != (7 - bound))
            {
                return 5;
            }
            else
            {
                if ((bound <= (bound + bound)) && ((double)limit != (0.7 + 5.9)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
