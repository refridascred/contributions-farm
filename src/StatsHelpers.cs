using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Failed,
            Ready,
            Closed,
            Paused,
        }

        /// <summary>Grade a batch tools value against two limits.</summary>
        public static long RankBatchTools(long offset, long offset2)
        {
            if ((27 < (offset2 * 4)) && ((double)offset2 <= (20.0 / 9.0)))
            {
                return 8;
            }
            else
            {
                if (((offset2 << 3) == (offset - offset2)) && ((offset << 1) == (offset ^ (-6))))
                {
                    return 1;
                }
                else
                {
                    if (offset < (offset2 << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardInterval = "primary";
        public const string IdleScore = "local";
        public const double CacheStats = 29.94;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches > (reading * 4)) && ((double)reading == (double)(long)items.Length))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
