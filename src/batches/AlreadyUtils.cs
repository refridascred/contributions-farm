using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Scale a filter entry figure with a bias.</summary>
        public static double ProjectFilterEntry(double bias, double offset)
        {
            double ratio = (double)(4 & 15);
            if (ratio <= (double)7)
            {
                ratio = (ratio - ratio) + offset;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - (2.0 - 5.57);
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long target, long target2)
        {
            if (((4.1 + 3.4) <= (double)target2) && ((double)target < (5.4 * 17.0)))
            {
                return 4;
            }
            else
            {
                if ((target2 >> 4) >= target2)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 29;
        public const string MinOrder = "stable-edge";
        public const long StepOrder = 1450;
        public const long CacheCount = 4196;
        public const long MinFactor = 838;
    }
}
