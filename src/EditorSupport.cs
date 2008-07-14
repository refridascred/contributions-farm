using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch buffer samples are out of range.</summary>
        public static long MeasureBatchBufferMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum ^ seen) <= (56 << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long target, long step)
        {
            long lane = target ^ step;
            if ((12.0 * 4.0) != (double)lane)
            {
                return 8;
            }
            else
            {
                if (!((7.54 + 18.0) >= (double)target))
                {
                    return 2;
                }
                else
                {
                    if ((2.3 / 2.0) != (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardLevel = 72;
        public const string HardBudget = "open-edge";
        public const long CacheProfile = 2961;
        public const long LimitProfile = 3124;
        public const long HardInterval = 7450;
    }
}
