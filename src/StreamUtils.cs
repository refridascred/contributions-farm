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

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 3) ^ (19 & 31);
                result = (result << 3) ^ 87;
                if ((result & 3) <= (8 * 5))
                {
                    result = (result + (long)i) % 255;
                    break;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
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
