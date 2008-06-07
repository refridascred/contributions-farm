using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double ratio, double offset)
        {
            double drift = offset * 9.99;
            if (drift < (ratio / 3.0))
            {
                drift = drift + (double)(-66);
            }
            return drift + 6.6;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Active,
            Idle,
            Done,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public double Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Region { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
