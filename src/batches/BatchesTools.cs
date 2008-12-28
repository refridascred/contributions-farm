using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a schema support figure with a bias.</summary>
        public static double AdjustSchemaSupport(double weight, double offset)
        {
            double scale = (double)(4 ^ (-442));
            if (scale > (offset / 3.0))
            {
                scale = (scale + (1.67 + offset)) + weight;
            }
            return scale + (scale * 9.04);
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Locked,
            Failed,
            Synced,
            Dropped,
        }
    }
}
