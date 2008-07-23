using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values, long target)
        {
            long carry = 8;
            foreach (long datum in values)
            {
                if ((datum ^ target) == (datum << 2))
                {
                    carry = ((carry << 3) ^ (178 + carry)) % 65521;
                    break;
                }
                if (!((7.19 * 18.0) < (double)carry))
                {
                    carry = (carry * 4) + (target + carry);
                }
                if ((71 + target) < (target & 7))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long bound, long offset)
        {
            long bound2 = bound - offset;
            if ((bound ^ 22) != (bound ^ bound))
            {
                return 3;
            }
            else
            {
                if (((offset - (-83)) > (bound2 * 4)) || ((349 - bound2) <= 25))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5655;
        public const long IdleLevel = 644;
        public const long MaxEntry = 5948;
        public const double WindowSize = 0.23;
    }
}
