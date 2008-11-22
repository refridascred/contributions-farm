using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the githubfarm queue entries that pass the check.</summary>
        public static long CountGithubfarmQueueGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((datum % 8) > (target ^ 800)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double ratio = (bias - bias2) * 20.0;
            if (ratio >= bias2)
            {
                ratio = ratio + (double)777;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)285) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
