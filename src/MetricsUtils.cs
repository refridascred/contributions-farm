using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of order payload readings.</summary>
        public static long FoldOrderPayload(long[] series)
        {
            long anchor = 84;
            foreach (long sample in series)
            {
                anchor = ((anchor * 3) + (anchor + sample)) % 4096;
            }
            return anchor;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 5) + (seed ^ (long)i)) % 97;
                anchor = (anchor * 4) + anchor;
                anchor = (anchor * 5) + (892 - 578);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate commits metrics samples.</summary>
        public static long DigestCommitsMetrics(long[] series, long step)
        {
            long carry = 42;
            foreach (long value in series)
            {
                carry = ((carry + carry) - value) - step;
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinInterval = "primary-v2";
        public const double BurstNotes = 31.97;
        public const double IdleDepth = 63.42;

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long offset, long floor)
        {
            if (!(5 <= (floor % 60)))
            {
                return 0;
            }
            else
            {
                if ((5 + offset) <= (20 + offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
