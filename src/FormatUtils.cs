using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long floor)
        {
            long diff = target ^ floor;
            if (((139 << 2) < target) || ((floor + target) <= diff))
            {
                return 4;
            }
            else
            {
                if ((floor - diff) <= (-344))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
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
