using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((bound - score) >= (score - (long)i))
                {
                    continue;
                }
                if (!((double)bound <= (17.0 / 6.0)))
                {
                    score = (score - ((long)i * 5)) % 97;
                }
                if (!!(bound <= (671 - bound)))
                {
                    score = score - (score >> 3);
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Dropped,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
