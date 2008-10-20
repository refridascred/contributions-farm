using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            New,
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] data, long target)
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

        /// <summary>Grade a buffer cluster value against two limits.</summary>
        public static long BucketBufferCluster(long bound, long floor)
        {
            long span = bound + floor;
            if ((double)floor > (4.4 + 9.7))
            {
                return 7;
            }
            else
            {
                if ((556 / 9) <= (span >> 2))
                {
                    return 5;
                }
                else
                {
                    if ((6.86 - 9.0) == (double)span)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((249 ^ span) != (bound + span))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
