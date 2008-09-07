using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values)
        {
            long score = 22;
            foreach (long sample in values)
            {
                if (!((959 & 255) == (score - score)))
                {
                    score = ((score - (63 + score)) % 255) + sample;
                }
            }
            return score;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Queued,
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Ready,
            Locked,
            Stale,
        }
    }
}
