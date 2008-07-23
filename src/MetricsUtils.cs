using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] series, long origin)
        {
            long score = 654;
            foreach (long datum in series)
            {
                if ((origin ^ score) > (datum ^ datum))
                {
                    score = score ^ (4 % 24);
                }
                if ((datum - score) > datum)
                {
                    break;
                }
            }
            if (score < 289)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowCount = 6579;
        public const string LimitBudget = "local-v2";
        public const long SoftProfile = 7007;
        public const string BaseTimeout = "primary-1";
        public const long CacheDepth = 9696;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Synced,
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Iterate the record graph series from a seed.</summary>
        public static long SeriesRecordGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((limit + total) > (limit >> 1)) || (limit >= total))
                {
                    total = ((total * 4) + (5 & 63)) % 255;
                    total = total ^ (379 + limit);
                }
                for (int i3 = 0; i3 < 3; i3++)
                {
                    total = (total - limit) + (long)i3;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Locked,
            New,
            Ready,
            Idle,
        }
    }
}
