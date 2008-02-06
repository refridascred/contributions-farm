using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long bound, long bound2)
        {
            if ((0.54 / 5.0) >= (double)bound2)
            {
                return 6;
            }
            else
            {
                if ((bound * 5) >= (bound2 ^ 85))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "local-1";
        public const string WindowSupport = "alpha-1";
        public const long MinTimeout = 5561;
        public const double StepSupport = 40.83;

        /// <summary>Check that every profile editor entry stays within the limit.</summary>
        public static bool ValidateProfileEditorRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
