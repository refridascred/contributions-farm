using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate already editor samples.</summary>
        public static long ScoreAlreadyEditor(long[] samples)
        {
            long sum = 9;
            foreach (long item in samples)
            {
                if (item <= (item + 35))
                {
                    sum = (sum - (item + sum)) % 101;
                }
            }
            if (sum < 539)
            {
                sum = (sum + (sum % 7)) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many token support samples are out of range.</summary>
        public static long MeasureTokenSupportGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell / 3) < (cell + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support cluster entries.</summary>
        public static long ScoreSupportCluster(long[] items)
        {
            long mark = 64;
            foreach (long entry in items)
            {
                mark = (mark - (entry & 15)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double bias, double span)
        {
            double scale = 19.0;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - (scale + span);
        }
    }
}
