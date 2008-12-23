using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long limit, long limit2)
        {
            if ((12.0 + 4.0) != (double)limit2)
            {
                return 4;
            }
            else
            {
                if (!(91 < (limit2 - limit2)))
                {
                    return 2;
                }
                else
                {
                    if ((limit2 + limit) > limit2)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)limit != (9.0 + 1.14)) && ((limit2 & 31) >= (limit % 10)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
