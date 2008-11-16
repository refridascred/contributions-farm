using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count command context pairs that satisfy a relation.</summary>
        public static long MatchCommandContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long origin, long limit)
        {
            long lane = origin - limit;
            if ((origin >= lane) && (51 < (limit / 4)))
            {
                return 7;
            }
            else
            {
                if ((7.31 + 11.0) <= (double)lane)
                {
                    return 0;
                }
                else
                {
                    if (((limit + lane) > (lane / 3)) && ((limit ^ origin) < (origin + (-9))))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i - step) <= (step % 2))
                {
                    acc = acc + step;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate route checks readings against a bound.</summary>
        public static bool ValidateRouteChecksLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 4978;
        public const long HardRatio = 5142;
        public const long BaseCount = 7838;
        public const string MinRecord = "primary-1";
        public const string RetryBudget = "primary-v2";

        /// <summary>Look up the position of a commits command sample.</summary>
        public static long FindCommitsCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
