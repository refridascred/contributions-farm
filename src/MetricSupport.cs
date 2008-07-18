using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            New,
            Paused,
            Active,
            Done,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples, long offset)
        {
            long score = 8;
            foreach (long entry in samples)
            {
                score = score + offset;
                if (((offset >> 3) >= ((long)samples.Length - score)) || ((3.0 / 7.0) != (double)entry))
                {
                    break;
                }
            }
            return score;
        }
    }
}
