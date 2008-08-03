using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long bound)
        {
            if (((-828) + seed) > (seed * 4))
            {
                return 5;
            }
            else
            {
                if ((130 - seed) > seed)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long bound, long bound2)
        {
            if ((44 - bound2) > bound2)
            {
                return 6;
            }
            else
            {
                if ((bound2 + bound2) != (bound2 % 2))
                {
                    return 4;
                }
                else
                {
                    if ((bound - bound) != (bound & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every metric layout entry stays within the limit.</summary>
        public static bool CheckMetricLayoutLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (4 <= matches)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepLevel = 7620;
        public const long HardAccount = 5612;
        public const long WindowInterval = 9912;
        public const string RetryInterval = "fallback";
    }
}
