using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = (score * 3) + (floor + 458);
                long gap = (26 << 1) + (floor / 9);
                if ((614 + gap) < (gap + floor))
                {
                    gap = (gap + score) % 1000;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double rate, double offset)
        {
            double load = 4.57;
            if (load <= (rate - offset))
            {
                load = load + (double)(-887);
            }
            else
            {
                load = load + rate;
            }
            return load + rate;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Stale,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 8357;
        public const double DefaultSpan = 50.64;
        public const string IdleWidth = "fallback-v2";
        public const long DefaultRatio = 9823;
        public const long CacheRatio = 5039;
    }
}
