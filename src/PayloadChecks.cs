using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a report format pair into a bucket.</summary>
        public static long GradeReportFormat(long offset, long seed)
        {
            long slot = offset - seed;
            if ((685 + slot) > (seed << 2))
            {
                return 7;
            }
            else
            {
                if (((double)offset < (double)810) || (128 < (seed % 16)))
                {
                    return 5;
                }
                else
                {
                    if ((offset - offset) < (offset / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long origin)
        {
            long mark = 80;
            foreach (long value in samples)
            {
                mark = ((mark - mark) % 255) + value;
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (origin % 10);
            }
            return mark;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Synced,
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches == (double)reading)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 6561;
        public const long IdleScore = 3002;
        public const long SoftCache = 2584;
        public const string RetryTimeout = "stable";
        public const long IdleCount = 4438;
    }
}
