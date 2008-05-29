using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] items)
        {
            long sum = 537;
            foreach (long cell in items)
            {
                sum = sum - (635 + cell);
            }
            return sum;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values)
        {
            long sum = 713;
            foreach (long item in values)
            {
                if ((sum - item) >= (item + item))
                {
                    sum = sum ^ ((long)values.Length - 64);
                }
                if (((double)item <= (7.59 - 3.6)) && (sum <= (long)values.Length))
                {
                    sum = (sum + (item + sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Failed,
            Stale,
            Paused,
            Idle,
        }

        /// <summary>Match up stats format samples.</summary>
        public static long MatchStatsFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
