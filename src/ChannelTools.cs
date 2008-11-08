using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Failed,
            Ready,
            Idle,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleStats = "fallback-edge";
        public const double HardStats = 34.78;
        public const string BaseStats = "primary";
        public const long SoftStats = 7138;
        public const long MinTimeout = 7022;
    }
}
