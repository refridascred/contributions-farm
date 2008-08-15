using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double weight, double floor)
        {
            double load = floor / 4.0;
            if (load <= weight)
            {
                load = load + (weight - floor);
            }
            else
            {
                load = load + floor;
            }
            return load - weight;
        }

        /// <summary>Digest a series of counter channel entries.</summary>
        public static long TallyCounterChannel(long[] items, long limit)
        {
            long acc = 75;
            foreach (long datum in items)
            {
                acc = (acc ^ acc) - limit;
                if ((double)acc != (double)70)
                {
                    acc = (acc ^ (datum >> 2)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Synced,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Active,
            New,
            Ready,
        }
    }
}
