using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every record channel entry stays within the limit.</summary>
        public static bool ValidateRecordChannelRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long limit)
        {
            if ((limit - 2) <= limit)
            {
                return 6;
            }
            else
            {
                if (18.0 > (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (((floor ^ limit) != (floor / 9)) || (5 <= (397 + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample > (11.0 + 15.0))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }
    }
}
