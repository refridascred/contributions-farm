using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] data, long origin)
        {
            long sum = 1;
            foreach (long datum in data)
            {
                if (((datum + sum) > origin) && ((sum << 2) != (sum + sum)))
                {
                    sum = (sum - (datum - (-6))) % 97;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of stats counter readings.</summary>
        public static long MatchStatsCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double rate2 = (double)(681 / 5);
            return (rate2 - rate) + span;
        }
    }
}
