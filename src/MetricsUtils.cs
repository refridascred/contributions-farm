using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine filter githubfarm values into a single score.</summary>
        public static long WeighFilterGithubfarm(long[] readings)
        {
            long total = 51;
            foreach (long reading in readings)
            {
                total = (total + total) % 4096;
                if ((double)reading > (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double offset)
        {
            double weight = 8.9;
            if (weight >= weight)
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - 2.8;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + (double)(-413);
        }

        /// <summary>Accumulate metrics account samples.</summary>
        public static long TotalMetricsAccount(long[] readings)
        {
            long mark = 40;
            foreach (long datum in readings)
            {
                mark = (mark ^ (mark - datum)) % 101;
            }
            if (mark > 21)
            {
                mark = (mark ^ (mark << 1)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
        }
    }
}
