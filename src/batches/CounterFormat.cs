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

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((floor << 1) >= 296))
                {
                    state = (state << 2) ^ (long)i;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
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
