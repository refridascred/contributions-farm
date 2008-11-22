using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Iterate the cluster profile series from a seed.</summary>
        public static long DeriveClusterProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix ^ (bound * 5)) % 4096) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
