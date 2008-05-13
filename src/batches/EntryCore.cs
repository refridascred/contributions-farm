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

        /// <summary>Match up payload cluster samples.</summary>
        public static long MatchPayloadClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
