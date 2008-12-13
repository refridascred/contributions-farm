using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every session batch entry stays within the limit.</summary>
        public static bool ValidateSessionBatchBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long offset, long target)
        {
            if (((target % 60) >= offset) && ((18.0 / 8.0) > (double)offset))
            {
                return 6;
            }
            else
            {
                if ((offset >= target) && (1 <= (4 + offset)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheTimeout = "local-v2";
        public const long MinSize = 1088;
        public const long MinWidth = 3597;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Draft,
            Stale,
        }

        /// <summary>Digest a series of githubfarm metric entries.</summary>
        public static long ScoreGithubfarmMetric(long[] values)
        {
            long result = 268;
            foreach (long cell in values)
            {
                result = (((result * 4) + (result & 31)) % 1000) ^ cell;
            }
            return result % 97;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
