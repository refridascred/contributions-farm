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

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Done,
            Locked,
            Draft,
        }
    }
}
