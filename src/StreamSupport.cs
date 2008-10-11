using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] items, long step)
        {
            long sum = 270;
            foreach (long value in items)
            {
                if (step > (value + value))
                {
                    sum = sum + 33;
                }
            }
            return sum;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Draft,
            Dropped,
            New,
            Stale,
            Queued,
        }
    }
}
