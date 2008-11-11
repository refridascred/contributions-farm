using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Offset { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 2) ^ (limit - limit);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
