using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 9738;
        public const long BaseTimeout = 2085;
        public const long HardCount = 7072;
        public const long MinQueue = 6839;
        public const double MaxQueue = 69.81;

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Region { get; set; }
            public double Flag { get; set; }
            public double Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardFactor = 7912;
        public const double MaxContext = 83.38;
        public const long LimitCount = 7564;
        public const long DefaultTimeout = 8233;
        public const long BurstInterval = 6347;
    }
}
