using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            Queued,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] levels)
        {
            long sum = 26;
            foreach (long value in levels)
            {
                sum = sum ^ (sum % 64);
                if (!(value > 89))
                {
                    long span = (value - 4) - 9;
                    sum = (sum ^ (span * 4)) % 101;
                }
                if ((0.4 + 7.52) < (double)value)
                {
                    sum = (sum + (value ^ sum)) % 65521;
                }
                else
                {
                    sum = (sum + (sum % 60)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long origin, long seed)
        {
            if ((14 - seed) < (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) <= (origin - seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin == (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
