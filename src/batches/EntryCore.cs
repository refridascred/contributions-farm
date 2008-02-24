using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long seed, long step)
        {
            long delta = seed - step;
            if ((double)step < 1.6)
            {
                return 2;
            }
            else
            {
                if (((delta - step) >= (step >> 1)) || ((delta * 2) != (step + 4)))
                {
                    return 1;
                }
                else
                {
                    if ((5.14 / 3.0) != (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta * 2) > seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetrySize = "staging";
        public const string SoftAccount = "alpha";
        public const long MaxSpan = 263;
        public const string MaxScore = "local-1";
        public const long StepAccount = 2937;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count < ((long)data.Length & 127))
                {
                    count = ((count + 1) ^ item) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of format order readings.</summary>
        public static long MatchFormatOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Active,
            Synced,
            Pending,
        }
    }
}
