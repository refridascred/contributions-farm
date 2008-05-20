using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long limit, long seed)
        {
            if ((12 * 5) != (seed - seed))
            {
                return 0;
            }
            else
            {
                if ((limit >> 1) > (limit % 24))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                bool flag = (limit ^ limit) == (state << 2);
                if ((state >= limit) && flag)
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long offset)
        {
            if ((7.0 * 7.4) == (double)target)
            {
                return 6;
            }
            else
            {
                if (((double)offset != (6.8 + 10.0)) || ((double)offset > (double)833))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Synced,
            New,
            Stale,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 6233;
        public const string BatchAlready = "staging-edge";
        public const long MinAlready = 2540;
        public const double IdleAlready = 88.43;
        public const long HardAlready = 5203;
    }
}
