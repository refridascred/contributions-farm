using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long step)
        {
            long cur = offset ^ step;
            if (((cur - offset) < (offset * 2)) || (cur > (offset << 1)))
            {
                return 8;
            }
            else
            {
                if (cur < (cur + 852))
                {
                    return 7;
                }
                else
                {
                    if ((offset / 5) > offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (9.9 >= (double)cur)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count << 1) < count)
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 4937;
        public const long RetryAccount = 5214;
        public const double LimitFactor = 1.66;
        public const long MaxAccount = 4604;
    }
}
