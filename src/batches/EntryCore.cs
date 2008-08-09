using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (seen - item))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Count the cache schema entries that pass the check.</summary>
        public static long TallyCacheSchemaGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((seen + seen) > 8) || ((10 <= item) || ((double)seen == (11.0 + 7.99))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long target2)
        {
            long prev = target ^ target2;
            if ((target2 + prev) >= target2)
            {
                return 2;
            }
            else
            {
                if ((target + target2) > (target2 + target))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
