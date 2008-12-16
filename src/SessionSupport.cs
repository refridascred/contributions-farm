using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Draft,
            Dropped,
            Retry,
            Locked,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long origin, long target)
        {
            if (origin > (target << 2))
            {
                return 0;
            }
            else
            {
                if (origin >= (target + origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin ^ origin) >= (target + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }
    }
}
