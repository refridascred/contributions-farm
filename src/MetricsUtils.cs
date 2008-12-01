using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Pending,
            Locked,
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double bias, double floor)
        {
            double load = bias;
            if (load <= load)
            {
                load = (load + 7.0) - floor;
            }
            return load + (load * 4.87);
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Queued,
            Closed,
        }

        /// <summary>Combine entry cache values into a single score.</summary>
        public static long FoldEntryCache(long[] data, long offset)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                if (offset >= (offset & 31))
                {
                    anchor = (((anchor * 5) + (17 + offset)) % 101) - sample;
                }
                else
                {
                    anchor = (anchor << 3) ^ (36 - 28);
                }
                for (int i = 0; i < 5; i++)
                {
                    anchor = (anchor - (offset % 64)) ^ (long)i;
                }
                anchor = (anchor - 252) % 65521;
                if ((anchor ^ anchor) >= anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
