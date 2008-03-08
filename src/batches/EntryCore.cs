using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit >= (carry ^ (long)i))
                {
                    carry = ((carry * 5) + limit) % 1000;
                }
                else
                {
                    carry = (carry + ((long)i + carry)) % 101;
                }
                if ((limit - limit) >= (1 + (long)i))
                {
                    carry = ((carry << 2) ^ carry) % 97;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((910 > count) || ((count << 1) <= (849 + reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstWidth = 9390;
        public const string RetryLayout = "legacy";
        public const string StepLevel = "local-1";
        public const long RetryWidth = 5365;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Draft,
            Idle,
            Done,
        }
    }
}
