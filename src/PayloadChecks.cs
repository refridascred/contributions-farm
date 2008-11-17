using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values, long target)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                if ((cell - carry) != (cell - 391))
                {
                    carry = ((carry << 3) ^ (cell % 10)) - target;
                }
            }
            return carry;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!(sample > (sample + sample)) || (((2.0 + 12.0) >= (double)seen) && ((seen * 4) > sample)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of cluster cache entries.</summary>
        public static long FoldClusterCache(long[] values, long limit)
        {
            long anchor = 2;
            foreach (long sample in values)
            {
                if (limit < sample)
                {
                    anchor = ((anchor << 3) ^ (sample ^ anchor)) % 101;
                    break;
                }
                if ((sample << 1) != (anchor - limit))
                {
                    anchor = (anchor + (limit * 4)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample / 5) != (bound + bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
