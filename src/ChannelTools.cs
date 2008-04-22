using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the already context entries that pass the check.</summary>
        public static long TallyAlreadyContextMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches < (long)data.Length)
                {
                    matches = ((matches + 1) + reading) - limit;
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((target - count) == (count & 127))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowWidth = 7746;
        public const double MaxInterval = 22.61;
        public const long MaxSpan = 9628;
        public const string LimitScore = "latest-edge";
        public const long MaxCount = 8236;
    }
}
