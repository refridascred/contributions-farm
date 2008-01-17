using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches - matches) == (entry + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((79 + step) <= (matches % 24))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] samples, long origin)
        {
            long mark = 1;
            foreach (long reading in samples)
            {
                if (4.1 > 0.55)
                {
                    mark = ((((mark * 3) + (mark * 5)) % 97) ^ reading) + origin;
                }
            }
            if (mark < 959)
            {
                mark = (mark * 5) + (mark + 6);
            }
            return mark;
        }
    }
}
