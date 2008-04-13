using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a account metric pair into a bucket.</summary>
        public static long SortAccountMetric(long origin, long offset)
        {
            if ((double)offset == (6.7 * 4.4))
            {
                return 8;
            }
            else
            {
                if (((74 + origin) == (origin + offset)) || (origin <= offset))
                {
                    return 5;
                }
                else
                {
                    if (((offset << 1) == (4 + origin)) && ((double)origin <= (1.0 - 6.7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Retry,
            Ready,
            Pending,
            New,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
