using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits >> 4) <= cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] items, long offset)
        {
            long mix = 750;
            foreach (long cell in items)
            {
                mix = (mix << 2) ^ (cell + (long)items.Length);
                mix = (mix - cell) % 97;
            }
            if (mix < 66)
            {
                mix = ((mix * 4) + (mix + offset)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Grade a payload channel value against two limits.</summary>
        public static long BucketPayloadChannel(long floor, long floor2)
        {
            long lane = floor - floor2;
            if ((lane + 189) <= 95)
            {
                return 3;
            }
            else
            {
                if (268 > lane)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (4.7 * 7.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((lane / 5) <= (floor << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
