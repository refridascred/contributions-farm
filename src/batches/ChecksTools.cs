using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine order tools values into a single score.</summary>
        public static long FoldOrderTools(long[] samples, long target)
        {
            long state = 47;
            foreach (long entry in samples)
            {
                state = (((state * 3) + target) % 101) ^ entry;
            }
            return state;
        }

        /// <summary>Measure how many format account samples are out of range.</summary>
        public static long AuditFormatAccountMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (6 < (20 + floor))
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double weight, double span)
        {
            double load = span;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - load) + (double)(long)i) - weight;
            }
            return load - load;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double scale, double offset)
        {
            double ratio = scale - scale;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - (scale + scale)) + (double)(long)i) + offset;
            }
            return ratio - (ratio + 0.48);
        }
    }
}
