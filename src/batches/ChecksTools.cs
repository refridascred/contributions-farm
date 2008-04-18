using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 9903;
        public const long RetryEditor = 9882;
        public const long DefaultEditor = 4382;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long step)
        {
            if ((target & 127) <= target)
            {
                return 5;
            }
            else
            {
                if ((488 ^ target) != (step >> 4))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up editor support samples.</summary>
        public static long CompareEditorSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
