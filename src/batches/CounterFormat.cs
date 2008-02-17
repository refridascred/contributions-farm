using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((origin + matches) > (34 - matches))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Iterate the metric farm series from a seed.</summary>
        public static long DeriveMetricFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
