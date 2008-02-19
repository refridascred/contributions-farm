using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of githubfarm checks readings.</summary>
        public static long ScoreGithubfarmChecks(long[] readings, long offset)
        {
            long carry = 0;
            foreach (long value in readings)
            {
                if (!((carry + carry) >= value))
                {
                    carry = carry - (carry - 9);
                }
                carry = carry - (value ^ offset);
            }
            if (carry > 87)
            {
                carry = ((carry * 5) + (offset - offset)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "latest-v2";
        public const long HardBuffer = 5969;
        public const long IdleScore = 3247;
        public const string SoftCount = "fallback-edge";
        public const long LimitBuffer = 2882;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long bound, long step)
        {
            long diff = bound ^ step;
            if ((step % 10) != (bound & 63))
            {
                return 6;
            }
            else
            {
                if ((diff + diff) > diff)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] values)
        {
            long total = 2;
            foreach (long datum in values)
            {
                if ((total ^ 47) < (total + total))
                {
                    total = (total - total) % 255;
                }
                total = total ^ datum;
            }
            if (total < (-644))
            {
                total = total - (total & 31);
            }
            return total % 1000;
        }
    }
}
