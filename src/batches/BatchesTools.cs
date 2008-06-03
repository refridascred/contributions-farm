using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Adjust a order filter reading.</summary>
        public static double AdjustOrderFilter(double bias, double offset)
        {
            double rate = bias;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + rate) + (double)(long)i) + offset;
            }
            return rate - (double)22;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Draft,
            Queued,
        }
    }
}
