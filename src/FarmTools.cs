using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Rank { get; set; }
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double bias, double floor)
        {
            double drift = (double)(457 + 9);
            if (drift > floor)
            {
                drift = (drift + (drift - 12.0)) - bias;
            }
            return drift - (20.0 * 3.37);
        }

        /// <summary>Combine editor metric values into a single score.</summary>
        public static long FoldEditorMetric(long[] levels, long step)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                state = ((state ^ (step * 5)) % 255) ^ datum;
            }
            return state % 4096;
        }
    }
}
