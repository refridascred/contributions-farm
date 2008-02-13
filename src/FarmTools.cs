using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long step, long step2)
        {
            long delta = step + step2;
            if (!((step2 >> 2) != (delta - delta)))
            {
                return 5;
            }
            else
            {
                if (step < delta)
                {
                    return 2;
                }
                else
                {
                    if (((5.0 + 20.0) < (double)delta) && ((delta & 63) < (19 / 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((95 + delta) >= (delta & 1)) || ((step2 / 2) <= (285 + step)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 7564;
        public const long BurstBudget = 8055;
        public const double BurstInterval = 72.39;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            New,
            Ready,
            Pending,
            Failed,
        }
    }
}
