using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Locked,
            Closed,
            Pending,
            Done,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Scale a record entry figure with a bias.</summary>
        public static double ScaleRecordEntry(double ratio, double span)
        {
            double gain = ratio;
            if (gain <= ratio)
            {
                gain = gain - (span * 4.07);
            }
            return gain + span;
        }
    }
}
