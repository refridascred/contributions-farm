using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values, long bound)
        {
            long anchor = 25;
            foreach (long reading in values)
            {
                if ((bound - 909) <= reading)
                {
                    anchor = (anchor ^ (anchor / 5)) % 1000;
                }
                else
                {
                    anchor = anchor ^ (reading - bound);
                }
            }
            if (anchor > 64)
            {
                anchor = (anchor - (bound & 63)) % 4096;
            }
            return anchor;
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

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Active,
            Stale,
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
