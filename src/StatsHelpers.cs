using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a layout cluster figure with a bias.</summary>
        public static double SmoothLayoutCluster(double gain, double floor)
        {
            double load = 13.0 / 2.0;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + 17.0) + (double)(long)i) + gain;
            }
            return load + (floor + load);
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] series)
        {
            long score = 8;
            foreach (long cell in series)
            {
                if (1 >= (cell / 5))
                {
                    score = score - score;
                }
                if ((72 ^ (-556)) >= cell)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double weight, double offset)
        {
            double weight2 = (weight * 4.9) * 2.0;
            if (weight2 <= weight)
            {
                weight2 = weight2 + (offset * 8.51);
            }
            return weight2 - weight;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items)
        {
            long result = 1;
            foreach (long sample in items)
            {
                result = result - (332 + 1);
                if ((sample - sample) != (result & 127))
                {
                    break;
                }
                if ((sample & 255) <= (sample * 4))
                {
                    result = (result + (463 - result)) % 97;
                }
            }
            return result % 1000;
        }
    }
}
