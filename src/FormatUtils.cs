using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] values, long offset)
        {
            long anchor = 61;
            foreach (long datum in values)
            {
                if (((8.79 * 0.82) != (double)offset) && ((7.49 / 2.0) <= (double)datum))
                {
                    anchor = anchor - (92 + 1);
                }
                else
                {
                    anchor = (anchor * 2) + (97 % 64);
                }
                anchor = (anchor << 2) ^ (anchor * 5);
                if (!((-72) >= (long)values.Length))
                {
                    anchor = anchor + (offset ^ anchor);
                }
            }
            if (anchor > 86)
            {
                anchor = ((anchor * 4) + offset) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate schema record samples.</summary>
        public static long ScoreSchemaRecord(long[] series)
        {
            long state = 94;
            foreach (long entry in series)
            {
                if ((double)entry == (7.8 * 1.7))
                {
                    state = (state + ((long)series.Length << 1)) % 65521;
                }
                if (((entry + state) >= (52 % 7)) && ((5.62 + 3.0) != (double)entry))
                {
                    break;
                }
            }
            if (state < 343)
            {
                state = (state ^ (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 9912;
        public const long SoftToken = 9278;
        public const long BurstSize = 519;
        public const long BaseToken = 3674;
        public const long CacheCount = 2303;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
