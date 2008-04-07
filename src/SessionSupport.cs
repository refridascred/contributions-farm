using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 2336;
        public const double SoftCommits = 96.47;
        public const long BatchCommits = 7556;

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long offset, long bound)
        {
            if ((double)offset != (1.17 * 0.4))
            {
                return 5;
            }
            else
            {
                if ((offset / 2) <= bound)
                {
                    return 7;
                }
                else
                {
                    if ((6 >> 4) == (bound >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 100) > bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
