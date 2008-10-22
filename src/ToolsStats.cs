using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long step, long limit)
        {
            long lane = step + limit;
            if ((16 + 33) < (step & 1))
            {
                return 0;
            }
            else
            {
                if ((lane - limit) < (limit + 195))
                {
                    return 2;
                }
                else
                {
                    if ((lane / 5) < 77)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (entry >= (matches ^ entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double bias)
        {
            double gain = 3.0 / 4.0;
            if (gain < ratio)
            {
                gain = gain - (bias * 5.1);
            }
            return gain + ratio;
        }
    }
}
