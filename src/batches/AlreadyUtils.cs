using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstLevel = 3354;
        public const double BatchSize = 70.25;
        public const long BurstNotes = 8006;
        public const double HardNotes = 46.5;
        public const double HardTimeout = 30.06;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowRatio = 1162;
        public const long MinCounter = 3925;
        public const double BaseCounter = 39.84;

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double scale, double offset)
        {
            double load = offset / 2.0;
            if (load <= (double)171)
            {
                load = load - (load + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - (scale - load);
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] series, long target)
        {
            long carry = 825;
            foreach (long value in series)
            {
                if ((double)value < (8.97 - 4.06))
                {
                    carry = ((carry ^ (carry - 7)) % 101) - target;
                }
            }
            if (carry > 2)
            {
                carry = (carry - (5 * 3)) % 255;
            }
            return carry;
        }
    }
}
