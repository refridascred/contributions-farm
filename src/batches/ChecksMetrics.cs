using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((54 + item) > (93 % 64))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell << 2) < (seen * 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Synced,
            Draft,
            Closed,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long target, long bound)
        {
            long span = target ^ bound;
            if ((double)bound < (12.0 / 5.0))
            {
                return 3;
            }
            else
            {
                if (!((double)target >= (double)span))
                {
                    return 0;
                }
                else
                {
                    if ((double)span < 4.1)
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

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinDepth = 1863;
        public const long MaxScore = 121;
        public const double BatchLevel = 20.21;
        public const long BaseNotes = 319;
        public const long IdleNotes = 524;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public double Token { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
