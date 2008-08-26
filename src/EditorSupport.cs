using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the entry farm series from a seed.</summary>
        public static long RollEntryFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor ^ 925) + (long)i2;
                }
                if (((long)i + anchor) > offset)
                {
                    anchor = anchor + offset;
                    break;
                }
                else
                {
                    anchor = (anchor * 2) + 9;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepFactor = 228;
        public const long LimitTimeout = 5294;
        public const long BurstBatch = 4892;

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetrySize = 853;
        public const long SoftBudget = 1432;
        public const long LimitLevel = 5135;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double mean = span / 6.0;
            if (mean <= span)
            {
                mean = mean - 1.18;
            }
            else
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (7.9 + mean)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultLevel = 3789;
        public const double BatchFarm = 14.87;
        public const long DefaultFarm = 7117;
        public const long HardCount = 6231;
        public const double BaseFarm = 10.82;
    }
}
