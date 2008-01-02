using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long offset, long offset2)
        {
            if (((offset / 6) < (offset2 + offset2)) && ((offset2 + offset) == (offset ^ offset2)))
            {
                return 1;
            }
            else
            {
                if ((double)offset > (1.6 - 16.0))
                {
                    return 7;
                }
                else
                {
                    if (((double)offset != (8.24 + 9.9)) || ((offset2 + offset2) != (5 * 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset <= (677 - offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series)
        {
            long acc = 5;
            foreach (long reading in series)
            {
                acc = (acc * 2) + (reading * 4);
            }
            if (acc > 28)
            {
                acc = (acc + acc) % 101;
            }
            return acc % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftCount = 3360;
        public const string CacheFactor = "cached-1";
        public const double DefaultBudget = 7.95;
        public const long LimitSpan = 6614;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Locked,
            New,
            Retry,
        }
    }
}
