using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] items, long limit)
        {
            long anchor = -8;
            foreach (long datum in items)
            {
                if ((anchor >> 3) > (limit % 64))
                {
                    anchor = (((anchor << 3) ^ (limit + limit)) % 101) + datum;
                }
                if ((double)anchor <= 4.77)
                {
                    break;
                }
            }
            if (anchor < 2)
            {
                anchor = (anchor + (anchor - limit)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinLevel = 6970;
        public const long MinToken = 3470;
        public const long IdleSize = 9606;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCount = 4708;
        public const double MaxCount = 68.65;
        public const string MaxInterval = "primary-edge";
        public const double LimitCommits = 22.07;
        public const double RetryCommits = 6.64;
    }
}
