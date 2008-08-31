using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinBudget = "staging-edge";
        public const long MinScore = 4090;
        public const long DefaultSize = 8300;
        public const string SoftCache = "cached";

        /// <summary>Validate checks cache readings against a bound.</summary>
        public static bool CheckChecksCacheRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((long)data.Length <= floor)
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Active,
            Ready,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((-6) + seed) != (531 / 3))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
