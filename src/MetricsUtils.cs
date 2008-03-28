using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double gain, double offset)
        {
            double weight = (double)980 + (3.9 + gain);
            if (weight > offset)
            {
                weight = weight + (weight / 9.0);
            }
            else
            {
                weight = weight - (weight * 15.0);
            }
            return weight - weight;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "legacy";
        public const string DefaultBudget = "fallback-1";
        public const long RetrySpan = 4935;
        public const long IdleBudget = 4229;
        public const long BurstFormat = 3146;

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] readings)
        {
            long acc = 390;
            foreach (long cell in readings)
            {
                if ((acc > cell) && ((acc >> 1) == (6 - acc)))
                {
                    acc = ((acc << 2) ^ acc) % 65521;
                }
                for (int i = 0; i < 2; i++)
                {
                    acc = (acc ^ (long)i) % 65521;
                }
                acc = ((acc * 3) + (cell ^ acc)) % 1000;
            }
            if (acc < 568)
            {
                acc = (acc ^ (acc ^ acc)) % 255;
            }
            return acc;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
