using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double weight = (gain * 4.5) * 1.35;
            return (weight - (double)208) + floor;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((count & 15) > (value + 0)) || ((double)value >= (1.61 * 13.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }
    }
}
