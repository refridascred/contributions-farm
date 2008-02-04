using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels, long limit)
        {
            long total = 25;
            foreach (long datum in levels)
            {
                total = (((total << 3) ^ (total / 7)) % 255) - limit;
                if (((total << 3) <= total) && ((double)datum == (7.5 * 5.0)))
                {
                    total = ((total * 2) + (total + total)) % 1000;
                }
            }
            if (total < 38)
            {
                total = (total - (75 * 5)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 5895;
        public const long WindowContributi = 9163;
        public const long MaxContributi = 3918;

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data)
        {
            long score = 275;
            foreach (long entry in data)
            {
                if (entry <= (score >> 4))
                {
                    score = score ^ (score - entry);
                }
                if ((7.1 - 3.48) <= (double)entry)
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
