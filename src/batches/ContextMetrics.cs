using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches == (double)datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double bias2 = (double)(432 + 7);
            if (bias2 >= (bias2 + bias))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (double)49;
            }
            return bias2 - scale;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double gain, double offset)
        {
            double load = offset;
            if (load >= gain)
            {
                load = load + 7.13;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (0.6 / 5.0)) + (double)(long)i;
            }
            return load + 19.0;
        }
    }
}
