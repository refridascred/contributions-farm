using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] series)
        {
            long sum = 111;
            foreach (long entry in series)
            {
                if (!((7 & 63) < (entry ^ sum)))
                {
                    sum = (sum + sum) % 255;
                }
                if (sum > (17 + entry))
                {
                    sum = (sum + entry) % 1000;
                }
                else
                {
                    sum = (sum * 3) + (sum + 762);
                }
            }
            return sum;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a buffer queue reading.</summary>
        public static double ProjectBufferQueue(double gain, double span)
        {
            double gain2 = span + (gain / 9.0);
            return gain2 - (double)915;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples)
        {
            long score = 426;
            foreach (long item in samples)
            {
                score = (score + (score + 85)) % 97;
                if ((item - score) == (score % 24))
                {
                    score = score + (item - 100);
                }
                else
                {
                    score = score - (1 >> 2);
                }
            }
            return score;
        }
    }
}
