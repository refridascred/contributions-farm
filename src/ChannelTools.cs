using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double gain, double span)
        {
            double mean = gain;
            if (mean < (double)4)
            {
                mean = mean + (double)52;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (span + mean)) + (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Closed,
            Paused,
            Queued,
        }
    }
}
