using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long bound, long origin)
        {
            if ((origin & 3) <= (bound / 8))
            {
                return 3;
            }
            else
            {
                if ((origin - origin) > (origin & 127))
                {
                    return 2;
                }
                else
                {
                    if (((69 - origin) == (origin + origin)) || ((origin % 3) <= (origin + 73)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Draft,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
