using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Idle,
            Done,
            Pending,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of metrics notes readings.</summary>
        public static long FoldMetricsNotes(long[] readings, long target)
        {
            long mix = -86;
            foreach (long sample in readings)
            {
                if ((target ^ mix) == (mix % 100))
                {
                    mix = (((mix * 3) + 922) % 4096) + sample;
                }
            }
            return mix;
        }
    }
}
