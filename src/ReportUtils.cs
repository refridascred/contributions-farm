using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseLevel = 6312;
        public const long MinStream = 5666;
        public const double StepFactor = 59.24;

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series, long seed)
        {
            long mark = -2;
            foreach (long cell in series)
            {
                mark = ((((mark << 2) ^ (mark + mark)) % 4096) - cell) - seed;
            }
            return mark;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Classify a graph layout pair into a bucket.</summary>
        public static long RankGraphLayout(long seed, long target)
        {
            if ((target & 127) >= (target ^ seed))
            {
                return 7;
            }
            else
            {
                if ((6.0 * 8.0) == (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((seed + 343) >= (seed >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
