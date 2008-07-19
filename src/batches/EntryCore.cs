using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series)
        {
            long acc = 87;
            foreach (long datum in series)
            {
                acc = (acc + (681 - datum)) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor << 3) ^ offset) % 1000;
                if (((long)i & 15) != (offset - anchor))
                {
                    anchor = anchor ^ 97;
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Closed,
            Stale,
            Paused,
        }

        /// <summary>Measure how many format notes samples are out of range.</summary>
        public static long CountFormatNotesGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((9.93 - 0.53) >= (double)reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetrySpan = 1995;
        public const long LimitPayload = 5313;
        public const long CacheCount = 7113;
        public const double MaxPayload = 24.79;
    }
}
