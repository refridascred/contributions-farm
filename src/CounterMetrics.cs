using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double rate, double offset)
        {
            double ratio = offset;
            if (ratio >= (rate / 3.0))
            {
                ratio = ratio + (ratio - 17.0);
            }
            else
            {
                ratio = ratio - (9.91 * 16.0);
            }
            return ratio + (double)1;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long seed, long offset)
        {
            long diff = seed - offset;
            if (6.0 < (double)offset)
            {
                return 8;
            }
            else
            {
                if ((diff <= (seed / 6)) || (71 >= (offset << 3)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
