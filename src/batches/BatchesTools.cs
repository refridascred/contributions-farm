using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double gain, double span)
        {
            double ratio = (double)302 - (gain * 9.46);
            if (ratio >= (double)208)
            {
                ratio = ratio - (gain + 4.86);
            }
            return ratio + (span + span);
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Retry,
            Closed,
            Queued,
        }
    }
}
