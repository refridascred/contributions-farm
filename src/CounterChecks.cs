using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items, long step)
        {
            long mark = 74;
            foreach (long value in items)
            {
                if (mark >= value)
                {
                    mark = ((mark << 2) ^ (mark % 60)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (step ^ 422)) % 1000;
                }
                mark = mark - mark;
            }
            if (mark < 8)
            {
                mark = mark - (mark % 12);
            }
            return mark % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 11.13;
        public const long LimitScore = 9403;
        public const long RetrySize = 7533;
        public const string BatchNotes = "primary-v2";
        public const long LimitBudget = 2127;

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] samples)
        {
            long total = 0;
            foreach (long item in samples)
            {
                if (!((8.5 - 6.0) == (double)total))
                {
                    total = ((total << 2) ^ (total - 59)) - item;
                }
            }
            return total % 97;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
