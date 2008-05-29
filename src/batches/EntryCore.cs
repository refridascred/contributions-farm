using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel stats measurements.</summary>
        public static double ProjectChannelStats(double rate, double span)
        {
            double bias = span;
            if (bias <= span)
            {
                bias = bias - (bias - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (bias / 3.0)) - (double)(long)i;
            }
            return bias + rate;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double drift = (offset * 14.0) / 4.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (bias * 3.1)) + (double)(long)i;
            }
            return drift - 3.38;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] levels, long limit)
        {
            long anchor = 6;
            foreach (long entry in levels)
            {
                if ((limit - limit) == (entry ^ anchor))
                {
                    anchor = (anchor << 2) ^ (12 >> 3);
                }
                anchor = anchor ^ (entry & 127);
            }
            return anchor;
        }
    }
}
