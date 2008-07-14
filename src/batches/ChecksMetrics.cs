using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double bias, double bias2)
        {
            double bias3 = (bias / 2.0) / 8.0;
            if (bias3 < (bias3 / 3.0))
            {
                bias3 = bias3 + bias;
            }
            else
            {
                bias3 = bias3 + (6.61 / 7.0);
            }
            return bias3 - bias2;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((10.0 / 4.0) >= (double)tally) && (((6 ^ entry) <= entry) && ((6.06 * 3.1) == (double)tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
