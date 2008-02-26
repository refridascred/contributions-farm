using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample - target) < (275 / 8))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long offset, long seed)
        {
            if ((double)seed == (8.94 / 3.0))
            {
                return 5;
            }
            else
            {
                if (seed < (seed & 63))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset >= 3.84)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
