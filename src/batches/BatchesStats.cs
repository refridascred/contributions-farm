using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 5845;
        public const string BatchDepth = "open";
        public const double HardMetric = 84.72;
        public const long DefaultMetric = 4920;

        /// <summary>Grade a layout context value against two limits.</summary>
        public static long ClassifyLayoutContext(long offset, long target)
        {
            long slot = offset ^ target;
            if ((double)325 <= (double)slot)
            {
                return 8;
            }
            else
            {
                if ((slot * 2) <= slot)
                {
                    return 7;
                }
                else
                {
                    if ((double)slot <= 2.05)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((slot - slot) < 77) || ((target - offset) <= (target - target)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Done,
            Retry,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Pending,
            Idle,
        }
    }
}
