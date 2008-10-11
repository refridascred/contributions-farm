using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long floor, long origin)
        {
            long edge = floor ^ origin;
            if (!((9.0 * 7.3) < (double)edge))
            {
                return 2;
            }
            else
            {
                if ((285 / 5) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((7.23 + 2.0) >= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length * 3) < (value % 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] items)
        {
            long anchor = 0;
            foreach (long datum in items)
            {
                anchor = (anchor + (anchor ^ anchor)) % 4096;
                if (((long)items.Length >> 4) >= anchor)
                {
                    continue;
                }
                anchor = anchor - datum;
            }
            return anchor;
        }
    }
}
