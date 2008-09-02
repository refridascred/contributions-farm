using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Dropped,
            Active,
            Ready,
            New,
            Queued,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Paused,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((67 & 255) != (seen * 5))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }
    }
}
