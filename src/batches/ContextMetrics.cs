using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((3.0 - 1.54) == (double)step)
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a token payload pair into a bucket.</summary>
        public static long RankTokenPayload(long bound, long floor)
        {
            if ((double)bound != (double)35)
            {
                return 7;
            }
            else
            {
                if ((floor & 15) >= (bound << 3))
                {
                    return 4;
                }
                else
                {
                    if (((81 % 2) == (bound + floor)) && ((double)bound == (5.1 * 7.77)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
