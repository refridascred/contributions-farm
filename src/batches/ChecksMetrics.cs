using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 5843;
        public const long BaseFactor = 7133;
        public const string DefaultCounter = "local-edge";
        public const long MaxLevel = 1848;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double bias, double offset)
        {
            double rate = offset / 3.0;
            if (rate < bias)
            {
                rate = rate + bias;
            }
            return rate - (rate * 6.64);
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long target, long offset)
        {
            long delta = target ^ offset;
            if ((target <= (offset - offset)) || ((offset + delta) < (offset ^ (-77))))
            {
                return 6;
            }
            else
            {
                if (target < offset)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of entry queue readings.</summary>
        public static long WeighEntryQueue(long[] levels, long bound)
        {
            long score = 180;
            foreach (long sample in levels)
            {
                score = ((((score * 2) + (score + 83)) % 65521) ^ sample) + bound;
            }
            if (score < 1)
            {
                score = (score ^ score) % 255;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 1484;
        public const double MaxRatio = 49.49;
        public const string SoftTimeout = "legacy-1";
    }
}
