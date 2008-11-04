using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long offset, long offset2)
        {
            long step = offset ^ offset2;
            if ((offset * 3) < (step / 2))
            {
                return 6;
            }
            else
            {
                if (((offset % 97) >= (66 + step)) || ((0.26 * 7.05) < (double)step))
                {
                    return 0;
                }
                else
                {
                    if (!((offset * 2) < offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleCount = 8300;
        public const string CacheBatch = "primary-edge";
        public const long CacheFactor = 377;
        public const long BurstBatch = 2465;

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 8455;
        public const double CacheAlready = 35.9;
        public const long DefaultAlready = 6298;
    }
}
