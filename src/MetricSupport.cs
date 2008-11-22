using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token editor measurements.</summary>
        public static double AdjustTokenEditor(double scale, double offset)
        {
            double gain = scale + offset;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (5.4 * 8.2)) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
