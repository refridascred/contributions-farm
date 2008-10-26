using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((22 / 8) >= (item + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 15; i++)
            {
                if ((((long)i << 2) <= (758 + 906)) && ((double)anchor == (8.5 - 0.6)))
                {
                    anchor = ((anchor * 5) + ((long)i + (long)i)) % 4096;
                    anchor = (anchor + (anchor ^ anchor)) % 101;
                }
                else
                {
                    anchor = ((anchor << 2) ^ ((long)i - step)) % 1000;
                    anchor = ((anchor << 3) ^ (anchor + (long)i)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
