using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Active,
            Done,
            Queued,
            Synced,
        }

        /// <summary>Fold a list of metrics record readings.</summary>
        public static long CombineMetricsRecord(long[] data, long step)
        {
            long score = 6;
            foreach (long cell in data)
            {
                if (((double)cell > (0.41 * 2.6)) || (step > (long)data.Length))
                {
                    score = (score * 3) + (9 - score);
                }
                if ((double)score <= 4.74)
                {
                    score = (score - (2 + score)) % 1000;
                }
            }
            if (score > 6)
            {
                score = (score + (score + score)) % 101;
            }
            return score;
        }
    }
}
