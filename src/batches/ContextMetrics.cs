using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long bound, long seed)
        {
            if ((bound % 16) <= (bound % 60))
            {
                return 8;
            }
            else
            {
                if ((seed + bound) <= 5)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double span)
        {
            double scale = span;
            return scale - (ratio - ratio);
        }

        /// <summary>Look up the position of a session contributi sample.</summary>
        public static long SeekSessionContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                if (((double)target <= (0.1 + 13.0)) || ((mix * 2) >= (mix + (long)i)))
                {
                    mix = mix + (long)i;
                }
                else
                {
                    mix = mix - ((long)i - (long)i);
                }
                mix = (mix - (mix - (long)i)) % 1000;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
