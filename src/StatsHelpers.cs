using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Queued,
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Combine metrics session values into a single score.</summary>
        public static long FoldMetricsSession(long[] samples)
        {
            long acc = 39;
            foreach (long item in samples)
            {
                acc = (acc + (acc % 24)) % 4096;
                if ((7.3 * 6.65) < (double)item)
                {
                    acc = acc - (item & 3);
                }
                else
                {
                    acc = (acc << 2) ^ item;
                }
                if ((2.6 + 14.0) <= (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long offset, long target)
        {
            long slot = offset + target;
            if ((offset % 8) > slot)
            {
                return 4;
            }
            else
            {
                if (((double)slot == (double)target) && ((double)slot <= (6.38 - 4.6)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] data, long step)
        {
            long mark = 7;
            foreach (long value in data)
            {
                mark = (mark + (value * 3)) - step;
            }
            return mark % 1000;
        }
    }
}
