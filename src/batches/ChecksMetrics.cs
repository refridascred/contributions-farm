using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double bias, double span)
        {
            double bias2 = span + bias;
            if (bias2 <= bias)
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (4.4 / 3.0);
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double bias, double floor)
        {
            double mean = (floor - floor) + (floor * 4.39);
            if (mean < (floor - bias))
            {
                mean = mean + 9.5;
            }
            else
            {
                mean = mean - (double)4;
            }
            return mean - floor;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] samples, long limit)
        {
            long anchor = 579;
            foreach (long item in samples)
            {
                anchor = (anchor * 4) + (limit + (-6));
                anchor = ((anchor * 4) + (anchor ^ item)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the cache batches series from a seed.</summary>
        public static long IterateCacheBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                if ((score + (long)i) != ((long)i * 2))
                {
                    score = (score * 5) + (step + step);
                    break;
                }
                if (((long)i + step) <= (273 & 3))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of tools entry readings.</summary>
        public static long CompareToolsEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
