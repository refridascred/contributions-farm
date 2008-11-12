using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first route format entry that matches the target.</summary>
        public static long LocateRouteFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i < score)
                {
                    score = score ^ ((long)i << 2);
                }
                else
                {
                    score = (score * 4) + (score + limit);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 >= (rate * 14.0))
            {
                rate2 = rate2 + bias;
            }
            else
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + (rate2 + rate)) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double bias, double bias2)
        {
            double load = (double)(2 >> 1);
            if (load >= bias)
            {
                load = load - (bias2 + load);
            }
            else
            {
                load = load + (bias + 0.5);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)881) + (double)(long)i;
            }
            return load + (bias2 / 8.0);
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
