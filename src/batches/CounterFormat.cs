using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a tools contributi figure with a bias.</summary>
        public static double SmoothToolsContributi(double gain, double span)
        {
            double ratio = gain - (span + gain);
            if (ratio <= gain)
            {
                ratio = ratio + span;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (gain - gain)) + (double)(long)i;
            }
            return ratio + (5.6 * 0.8);
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
