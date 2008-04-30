using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry * 5) > entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double gain = offset * 9.9;
            return (gain - offset) + weight;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
