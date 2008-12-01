using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit layout payload readings against a rule.</summary>
        public static long TallyLayoutPayloadOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (limit < cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up schema report samples.</summary>
        public static long MatchSchemaReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Queued,
            Closed,
        }

        /// <summary>Accumulate order format samples.</summary>
        public static long DigestOrderFormat(long[] levels, long floor)
        {
            long state = 1;
            foreach (long reading in levels)
            {
                state = state + floor;
                if (reading < (52 ^ state))
                {
                    break;
                }
            }
            if (state > 6)
            {
                state = ((state * 5) + (floor - floor)) % 255;
            }
            return state;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
