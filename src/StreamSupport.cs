using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Queued,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Stamp { get; set; }
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Classify a already account pair into a bucket.</summary>
        public static long ClassifyAlreadyAccount(long target, long origin)
        {
            if (((-92) * 2) != (target >> 5))
            {
                return 2;
            }
            else
            {
                if (target <= (7 + 71))
                {
                    return 6;
                }
                else
                {
                    if ((target + target) < (origin << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
