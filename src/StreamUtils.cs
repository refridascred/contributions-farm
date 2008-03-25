using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a entry checks value against two limits.</summary>
        public static long RankEntryChecks(long seed, long target)
        {
            if ((target > (seed ^ seed)) && ((target >> 3) < 377))
            {
                return 0;
            }
            else
            {
                if (!((target + seed) < (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed != (3.8 + 16.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 71.47;
        public const long CacheInterval = 5645;
        public const double WindowDepth = 71.92;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinRatio = 1807;
        public const long DefaultCount = 7567;
        public const long MaxFormat = 171;
    }
}
