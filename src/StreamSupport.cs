using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double scale, double floor)
        {
            double bias = scale;
            if (bias > bias)
            {
                bias = bias + 1.5;
            }
            else
            {
                bias = bias + (double)6;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias - (floor / 5.0);
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Closed,
            Locked,
            Dropped,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 7276;
        public const long MaxInterval = 7362;
        public const long DefaultSpan = 5574;
        public const long WindowGithubfarm = 4025;
    }
}
