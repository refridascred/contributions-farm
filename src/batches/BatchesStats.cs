using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double ratio, double floor)
        {
            double weight = 12.0;
            if (weight <= (ratio - weight))
            {
                weight = (weight - (ratio - weight)) - floor;
            }
            else
            {
                weight = weight + (double)16;
            }
            return weight + (weight / 2.0);
        }

        /// <summary>Validate cache filter readings against a bound.</summary>
        public static bool VerifyCacheFilterRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                long lane = score + 86;
                if ((8.0 - 6.1) > (double)lane)
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Project the next contributi filter value.</summary>
        public static double ProjectContributiFilter(double gain, double span)
        {
            double mean = gain;
            if (mean <= (double)987)
            {
                mean = (mean - (gain * 6.0)) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - (gain * 12.0);
        }
    }
}
