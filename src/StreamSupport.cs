using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every token already entry stays within the limit.</summary>
        public static bool VerifyTokenAlreadyBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first already metric entry that matches the target.</summary>
        public static long LocateAlreadyMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long offset, long seed)
        {
            if (!((seed - 71) < seed))
            {
                return 7;
            }
            else
            {
                if ((offset < (seed << 2)) || ((double)seed < (10.0 - 3.1)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
