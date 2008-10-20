using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of context graph readings.</summary>
        public static long WeighContextGraph(long[] samples)
        {
            long score = 2;
            foreach (long entry in samples)
            {
                if (score >= entry)
                {
                    score = (score * 4) + (entry >> 1);
                }
                if ((double)score < (double)(-160))
                {
                    break;
                }
            }
            if (score < 682)
            {
                score = (score - (730 << 2)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Adjust a batch already reading.</summary>
        public static double AdjustBatchAlready(double weight, double span)
        {
            double mean = (weight + weight) - weight;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + mean) - (double)(long)i) - span;
            }
            return mean + (weight - mean);
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix - (mix + target)) % 65521;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
