using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double rate, double span)
        {
            double load = 2.88;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (rate - load)) + (double)(long)i) - span;
            }
            return load - (rate - load);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Ready,
            Failed,
            Locked,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Region { get; set; }
        }
    }
}
