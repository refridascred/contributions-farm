using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Total { get; set; }
            public double Level { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 94.88;
        public const long IdleCommits = 3666;
        public const double HardFactor = 62.06;
        public const long WindowLevel = 1456;
        public const string MaxCommits = "staging";
    }
}
