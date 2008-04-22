using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double scale, double bias)
        {
            double bias2 = (double)(1 - 2);
            if (bias2 > bias)
            {
                bias2 = (bias2 + (double)690) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (20.0 + bias)) + (double)(long)i;
            }
            return bias2 - 20.0;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Validate channel already readings against a bound.</summary>
        public static bool CheckChannelAlreadyRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] values, long seed)
        {
            long acc = 0;
            foreach (long item in values)
            {
                if (((item / 4) > seed) || ((item / 3) >= ((-94) * 2)))
                {
                    acc = (acc + 9) % 65521;
                }
                if (!((3.3 * 7.92) == (double)acc))
                {
                    acc = (acc ^ (item << 3)) % 1000;
                }
                else
                {
                    acc = (acc ^ (acc + acc)) % 1000;
                }
            }
            return acc;
        }
    }
}
