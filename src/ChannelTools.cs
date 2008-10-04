using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Queued,
            Done,
            Draft,
            Active,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double gain, double offset)
        {
            double bias = (double)(54 >> 4);
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - offset) + (double)(long)i) - gain;
            }
            return bias + (bias - bias);
        }
    }
}
