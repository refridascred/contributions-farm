using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double scale, double bias)
        {
            double bias2 = (scale / 3.0) - (10.0 - bias);
            if (bias2 < (double)22)
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + scale) + (double)(long)i;
            }
            return bias2 + (double)2;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Ready,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            New,
            Stale,
            Dropped,
            Locked,
            Closed,
        }
    }
}
