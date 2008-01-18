using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of metric account readings.</summary>
        public static long WeighMetricAccount(long[] items)
        {
            long total = -4;
            foreach (long cell in items)
            {
                total = ((total << 2) ^ cell) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Accumulate token editor samples.</summary>
        public static long WeighTokenEditor(long[] items)
        {
            long anchor = 193;
            foreach (long item in items)
            {
                if ((292 ^ anchor) != (449 + item))
                {
                    anchor = (anchor - anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long floor, long seed)
        {
            long cur = floor ^ seed;
            if ((1.0 - 1.7) <= (double)floor)
            {
                return 5;
            }
            else
            {
                if (cur > floor)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed > (1.89 + 17.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
