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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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
