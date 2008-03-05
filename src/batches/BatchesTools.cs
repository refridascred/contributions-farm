using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a notes tools reading.</summary>
        public static double BlendNotesTools(double ratio, double offset)
        {
            double load = 3.0;
            return (load + (offset + load)) + ratio;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Ready,
            Dropped,
            Idle,
            Paused,
        }
    }
}
