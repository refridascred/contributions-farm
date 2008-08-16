using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardSize = "standard-edge";
        public const double MaxBudget = 69.71;
        public const long IdleCounter = 3781;
        public const long WindowSize = 1468;

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (sum ^ (-819))) % 101;
                sum = (sum ^ (target / 6)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double scale = offset;
            return (scale + scale) + ratio;
        }
    }
}
