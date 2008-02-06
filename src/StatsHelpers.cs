using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the record editor series from a seed.</summary>
        public static long SeriesRecordEditor(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double rate, double bias)
        {
            double load = (double)162 / 6.0;
            if (load <= load)
            {
                load = load + (load + rate);
            }
            else
            {
                load = load - (bias - rate);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + rate) - (double)(long)i;
            }
            return load - (rate * 2.51);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheRatio = 4847;
        public const double MinLayout = 80.73;
        public const double LimitCount = 11.35;

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items)
        {
            long acc = 851;
            foreach (long entry in items)
            {
                acc = ((acc * 2) + (entry ^ entry)) % 1000;
            }
            return acc;
        }
    }
}
