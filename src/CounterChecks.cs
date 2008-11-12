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

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Validate cluster metrics readings against a bound.</summary>
        public static bool ValidateClusterMetricsLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] values)
        {
            long result = 9;
            foreach (long reading in values)
            {
                result = result - (89 - result);
                if (result <= (reading + result))
                {
                    result = (result - (reading ^ reading)) % 65521;
                }
                if ((11.0 + 5.34) == (double)result)
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
