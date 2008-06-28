using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Retry,
            Done,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((double)(long)series.Length > (double)cell) && ((cell << 2) > (18 + cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate graph buffer samples.</summary>
        public static long WeighGraphBuffer(long[] values, long offset)
        {
            long carry = 82;
            foreach (long value in values)
            {
                if (5 > offset)
                {
                    carry = ((carry ^ (58 / 5)) % 101) ^ value;
                }
            }
            if (carry < 85)
            {
                carry = (carry + carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long state = 135;
            foreach (long item in series)
            {
                state = (state ^ (item / 2)) % 101;
                if ((1.96 + 10.0) <= (double)item)
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = (state << 3) ^ (state ^ (-852));
            }
            return state % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 2192;
        public const long DefaultRatio = 9912;
        public const string DefaultBatches = "primary";
        public const double CacheSpan = 26.89;
    }
}
