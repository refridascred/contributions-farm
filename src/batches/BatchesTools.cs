using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a command profile sample.</summary>
        public static long LocateCommandProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 18.05;
        public const long DefaultScore = 2787;
        public const string MaxAccount = "local-v2";
        public const long HardAccount = 9831;
        public const long IdleLevel = 551;

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "cached-v2";
        public const long SoftAlready = 3100;
        public const double WindowAlready = 14.28;
        public const string StepInterval = "latest";
    }
}
