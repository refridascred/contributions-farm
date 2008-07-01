using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((-71) ^ (long)levels.Length) <= 75) || !((4 ^ seen) < seen))
                {
                    seen = ((seen + 2) + item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
