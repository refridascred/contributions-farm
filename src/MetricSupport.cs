using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            New,
            Pending,
            Idle,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long origin)
        {
            if (((double)offset != (5.83 + 5.6)) || ((double)origin <= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((origin % 24) < (offset + origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin / 7) < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
