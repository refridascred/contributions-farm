using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double weight, double span)
        {
            double drift = span;
            return (drift - (double)122) + weight;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long bound)
        {
            long result = -50;
            foreach (long entry in levels)
            {
                if ((result < (entry * 4)) && (((long)levels.Length - result) == (bound << 1)))
                {
                    result = (result + (bound - bound)) % 4096;
                }
            }
            if (result < 2)
            {
                result = (result << 2) ^ ((long)levels.Length << 1);
            }
            return result % 65521;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            New,
            Failed,
            Idle,
        }
    }
}
