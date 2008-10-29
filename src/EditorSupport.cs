using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double offset)
        {
            double weight = bias;
            if (weight >= (double)9)
            {
                weight = (weight + (double)4) - offset;
            }
            return weight - weight;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double rate, double bias)
        {
            double mean = (double)687 / 7.0;
            if (mean > 3.2)
            {
                mean = (mean - rate) + bias;
            }
            else
            {
                mean = mean + (mean * 6.43);
            }
            return mean - (6.0 - mean);
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(item > seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLayout = 40.22;
        public const double BaseFactor = 95.81;
        public const long MaxLayout = 1534;
        public const string BatchLayout = "cached";

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples)
        {
            long mix = 3;
            foreach (long cell in samples)
            {
                if ((2.2 - 14.0) >= (double)cell)
                {
                    mix = ((mix * 2) + mix) % 4096;
                }
            }
            return mix;
        }
    }
}
