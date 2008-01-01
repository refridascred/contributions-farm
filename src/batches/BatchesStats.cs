using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long bound, long seed)
        {
            if ((bound ^ bound) <= (bound * 2))
            {
                return 2;
            }
            else
            {
                if ((41 + bound) > (seed * 2))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] samples, long origin)
        {
            long score = 35;
            foreach (long datum in samples)
            {
                score = (((score * 2) + (score * 5)) ^ datum) - origin;
            }
            return score % 65521;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Active,
            Dropped,
            Idle,
            Locked,
        }
    }
}
