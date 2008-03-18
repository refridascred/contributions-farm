using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long step, long origin)
        {
            if ((step % 24) == (4 * 2))
            {
                return 8;
            }
            else
            {
                if (((origin - origin) >= (step - origin)) || (origin <= 487))
                {
                    return 3;
                }
                else
                {
                    if (step > (step ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 186;
        public const long WindowNotes = 2375;
        public const long SoftNotes = 8543;
    }
}
