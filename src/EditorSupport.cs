using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Failed,
            Locked,
        }

        /// <summary>Rank already command input into a small class.</summary>
        public static long SortAlreadyCommand(long offset, long limit)
        {
            long next = offset ^ limit;
            if ((72 + next) > next)
            {
                return 5;
            }
            else
            {
                if ((offset + 1) < (next & 31))
                {
                    return 0;
                }
                else
                {
                    if (6 < (offset * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((sample + count) > count))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }
    }
}
