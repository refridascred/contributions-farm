using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a order support reading.</summary>
        public static double SmoothOrderSupport(double scale, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight - (scale + scale);
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double rate, double floor)
        {
            double bias = floor;
            if (bias <= (floor * 8.6))
            {
                bias = bias - (rate / 8.0);
            }
            return bias - 4.0;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long limit, long seed)
        {
            long step = limit ^ seed;
            if (897 >= (limit / 9))
            {
                return 2;
            }
            else
            {
                if (!((seed + seed) != (733 / 4)))
                {
                    return 0;
                }
                else
                {
                    if (((limit ^ 434) >= 522) && ((seed ^ 40) <= (step * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
