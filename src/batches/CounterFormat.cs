using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowScore = 7617;
        public const string BaseStats = "local";
        public const long SoftInterval = 1300;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((floor + acc) > (long)i)
                {
                    acc = ((acc << 2) ^ acc) % 4096;
                    acc = acc + ((long)i % 3);
                }
                else
                {
                    acc = (acc - acc) % 255;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleLevel = 59.83;
        public const double MinProfile = 58.2;
        public const double DefaultProfile = 26.02;
    }
}
