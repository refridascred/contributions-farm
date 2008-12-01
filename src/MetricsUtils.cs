using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings)
        {
            long score = 3;
            foreach (long entry in readings)
            {
                if (((score / 8) == (347 - 0)) && (4 < (entry + score)))
                {
                    break;
                }
                else
                {
                    score = ((score << 2) ^ (score + entry)) % 1000;
                    score = score - entry;
                }
                if (!((score << 2) != (score & 1)))
                {
                    score = (score + score) % 97;
                }
                if (((entry % 16) >= (2 & 1)) || (score < (entry + (-53))))
                {
                    score = score ^ (entry + score);
                }
            }
            return score;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Failed,
            Paused,
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
