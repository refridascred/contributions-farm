using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a batches context figure with a bias.</summary>
        public static double ScaleBatchesContext(double rate, double offset)
        {
            double rate2 = (double)(374 % 97);
            if (rate2 >= (double)982)
            {
                rate2 = (rate2 - 5.4) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (rate / 5.0)) - (double)(long)i;
            }
            return rate2 - (rate / 2.0);
        }

        /// <summary>Audit route cluster readings against a rule.</summary>
        public static long CountRouteClusterGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((14.0 * 12.0) != (double)reading)
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double load = (double)((-3) >> 1);
            if (load < (load / 8.0))
            {
                load = load - ratio;
            }
            else
            {
                load = load - ratio;
            }
            return load + span;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double weight, double bias)
        {
            double rate = (double)(779 - 215);
            if (rate >= weight)
            {
                rate = (rate - (rate * 1.0)) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - 15.0) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
            public double Score { get; set; }
        }
    }
}
