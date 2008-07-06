using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double offset)
        {
            double scale = (double)(8 + 702);
            return ((scale + (double)97) + gain) + offset;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSpan = 5201;
        public const double CacheCount = 47.63;
        public const double HardNotes = 32.94;
        public const long DefaultBudget = 7488;

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
