using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long floor, long target)
        {
            if ((target * 3) <= (target * 2))
            {
                return 4;
            }
            else
            {
                if ((58 * 4) < (target + target))
                {
                    return 2;
                }
                else
                {
                    if ((89 + target) >= target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((-10) < (target / 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Pending,
            Active,
            Paused,
            Idle,
        }

        /// <summary>Iterate the stream counter series from a seed.</summary>
        public static long DeriveStreamCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
