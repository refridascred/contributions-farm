using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Done,
            Ready,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data)
        {
            long mark = 329;
            foreach (long value in data)
            {
                if ((6.0 <= 6.38) || ((double)value < (18.0 + 9.63)))
                {
                    mark = (mark - (4 / 2)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Weight { get; set; }
            public bool Token { get; set; }
        }
    }
}
