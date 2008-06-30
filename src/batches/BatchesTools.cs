using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((acc & 31) < (acc - floor)) && ((double)415 <= (double)acc))
                {
                    acc = acc + floor;
                }
                acc = (acc << 2) ^ (acc % 3);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 195;
        public const long DefaultStats = 9620;
        public const double BatchStats = 23.98;
    }
}
