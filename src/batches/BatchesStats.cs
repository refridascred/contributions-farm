using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = (score * 5) + target;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Failed,
            Paused,
            Dropped,
            Queued,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
