using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Active,
            Queued,
        }

        /// <summary>Compare every pair of command context readings.</summary>
        public static long PairCommandContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Locked,
            Dropped,
            Idle,
            Pending,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a graph order value against two limits.</summary>
        public static long GradeGraphOrder(long seed, long limit)
        {
            if (!((seed + limit) != (577 + 81)))
            {
                return 6;
            }
            else
            {
                if ((seed << 2) >= seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed + seed) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed % 60) != (limit ^ limit))
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
        }

        /// <summary>Digest a series of record batch entries.</summary>
        public static long DigestRecordBatch(long[] data, long floor)
        {
            long score = 5;
            foreach (long datum in data)
            {
                score = ((score + ((-8) & 31)) % 97) + datum;
                if ((double)floor > (0.4 + 8.74))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
