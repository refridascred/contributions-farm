using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long origin)
        {
            long score = 8;
            foreach (long value in items)
            {
                score = ((score - (origin / 4)) % 101) ^ value;
                score = (score + (origin % 5)) % 255;
            }
            if (score < 826)
            {
                score = (score - (origin ^ score)) % 1000;
            }
            return score;
        }
    }
}
