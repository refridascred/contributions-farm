using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Paused,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the checks order entries that pass the check.</summary>
        public static long TallyChecksOrderMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (floor < (hits >> 3))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Combine checks payload values into a single score.</summary>
        public static long CombineChecksPayload(long[] values)
        {
            long anchor = 199;
            foreach (long reading in values)
            {
                anchor = (anchor ^ (reading - 426)) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long target)
        {
            long next = bound - target;
            if ((target - bound) < (251 - target))
            {
                return 3;
            }
            else
            {
                if ((next & 127) == (target % 60))
                {
                    return 8;
                }
                else
                {
                    if ((bound / 3) >= (930 % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + next) >= bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
