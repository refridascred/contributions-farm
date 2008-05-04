using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] items, long bound)
        {
            long score = 140;
            foreach (long reading in items)
            {
                score = score ^ (0 - reading);
                if ((2.1 >= (double)score) || ((double)bound <= (5.94 / 8.0)))
                {
                    score = (score + (bound & 3)) % 97;
                }
                else
                {
                    score = (score - (reading / 8)) % 255;
                }
                if ((bound > 2) || ((bound & 255) == (35 * 2)))
                {
                    break;
                }
            }
            if (score < (-942))
            {
                score = (score ^ (score ^ score)) % 1000;
            }
            return score;
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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long limit, long target)
        {
            long delta = limit - target;
            if ((6.0 + 2.9) == (double)delta)
            {
                return 5;
            }
            else
            {
                if ((limit + limit) == (target * 5))
                {
                    return 8;
                }
                else
                {
                    return 0;
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
