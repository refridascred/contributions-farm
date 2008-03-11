using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] values)
        {
            long carry = 2;
            foreach (long reading in values)
            {
                if ((double)(long)values.Length > (4.45 + 8.0))
                {
                    carry = (((carry * 3) + (carry + 162)) % 255) ^ reading;
                }
            }
            return carry % 65521;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((bound < (0 >> 5)) || ((double)mix > 18.0))
                {
                    long cur = bound / 3;
                    mix = (mix + cur) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Blend two checks session measurements.</summary>
        public static double ScaleChecksSession(double rate, double bias)
        {
            double mean = (double)444 + (bias - rate);
            if (mean >= (mean + bias))
            {
                mean = mean + (double)233;
            }
            return mean + (rate * 1.5);
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Paused,
            Queued,
            Retry,
            New,
        }
    }
}
