using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two filter already measurements.</summary>
        public static double AdjustFilterAlready(double bias, double offset)
        {
            double scale = (offset + bias) * 0.32;
            if (scale < (scale + scale))
            {
                scale = scale + (scale + 7.12);
            }
            else
            {
                scale = scale - bias;
            }
            return scale + offset;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            Pending,
            Active,
            Synced,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] levels)
        {
            long acc = 943;
            foreach (long datum in levels)
            {
                if (!((0.15 * 0.42) >= (double)acc))
                {
                    acc = (acc - 4) + datum;
                }
                if ((14 % 16) <= (acc / 3))
                {
                    break;
                }
            }
            if (acc < 9)
            {
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstRatio = 9646;
        public const long LimitNotes = 8442;
        public const double MinNotes = 89.46;
        public const long CacheInterval = 9527;
    }
}
