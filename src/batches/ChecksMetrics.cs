using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                score = score + (score - bound);
                score = ((score * 3) + (score + bound)) % 4096;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
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
