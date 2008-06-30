using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double drift = 4.87;
            if (drift <= bias)
            {
                drift = drift + (ratio + 9.35);
            }
            return drift + (bias * 0.21);
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Failed,
            Closed,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double load = (double)(-90) / 4.0;
            if (load < load)
            {
                load = load + (weight + load);
            }
            return load - span;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data)
        {
            long mark = 921;
            foreach (long entry in data)
            {
                mark = (mark - (entry + mark)) % 1000;
                if ((double)(long)data.Length != (double)mark)
                {
                    mark = mark + mark;
                }
                else
                {
                    mark = ((mark * 2) + (entry >> 3)) % 97;
                }
            }
            if (mark < 34)
            {
                mark = (mark + (mark ^ mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 2980;
        public const long MaxCount = 2634;
        public const long StepTools = 6045;
        public const long BurstDepth = 2700;
        public const string IdleTools = "local";
    }
}
