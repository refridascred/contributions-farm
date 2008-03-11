using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
