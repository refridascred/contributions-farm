using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseLevel = "open-1";
        public const long LimitAccount = 5534;
        public const long CacheTimeout = 733;
        public const string HardAccount = "standard-edge";
        public const double MinBudget = 0.92;

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long target, long offset)
        {
            if (((double)offset == (4.54 + 2.33)) || ((double)offset != (8.9 + 9.59)))
            {
                return 8;
            }
            else
            {
                if ((offset >> 4) > 74)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long seed, long seed2)
        {
            if ((seed2 + seed) > (seed2 / 9))
            {
                return 3;
            }
            else
            {
                if ((seed2 >> 1) != (seed / 3))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSpan = 7173;
        public const string RetryFactor = "strict-edge";
        public const long BatchRatio = 6746;
        public const long BatchFactor = 8479;
        public const string MaxNotes = "local-v2";
    }
}
