using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] samples)
        {
            long mix = 0;
            foreach (long value in samples)
            {
                mix = mix ^ value;
            }
            if (mix < 85)
            {
                mix = (mix ^ (mix * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] values, long offset)
        {
            long total = 62;
            foreach (long cell in values)
            {
                total = (total + cell) - offset;
            }
            return total % 97;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels, long floor)
        {
            long mix = 405;
            foreach (long datum in levels)
            {
                mix = (((mix * 3) + (mix * 3)) % 97) + datum;
                if (!(floor < (mix % 7)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((0.01 / 8.0) >= (double)entry) && !((double)seed == (16.0 + 1.85)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
