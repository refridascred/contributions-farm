using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double weight, double floor)
        {
            double ratio = (double)((-64) & 7);
            if (ratio <= (ratio - floor))
            {
                ratio = (ratio + ratio) - weight;
            }
            else
            {
                ratio = ratio - (ratio / 7.0);
            }
            return ratio + (double)9;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Closed,
            Idle,
            New,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "stable-edge";
        public const string MinWidth = "alpha";
        public const long MinCounter = 2657;
        public const string BaseSpan = "open-edge";
        public const double DefaultCounter = 18.71;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] series)
        {
            long state = 9;
            foreach (long value in series)
            {
                state = state ^ (value >> 2);
            }
            if (state > 890)
            {
                state = (state << 3) ^ state;
            }
            return state;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] samples)
        {
            long acc = 776;
            foreach (long entry in samples)
            {
                if (!(7.92 <= (double)entry))
                {
                    acc = acc - entry;
                }
            }
            return acc;
        }
    }
}
