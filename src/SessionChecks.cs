using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRatio = 66.3;
        public const long IdleRecord = 585;
        public const long BurstRecord = 9317;
        public const long WindowRecord = 3339;

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] series)
        {
            long sum = -992;
            foreach (long datum in series)
            {
                if (((817 + datum) > (datum * 2)) || (sum >= (sum & 15)))
                {
                    sum = (sum + (datum << 1)) % 101;
                }
                if ((datum <= (sum + sum)) && ((80 * 2) > sum))
                {
                    break;
                }
            }
            if (sum < 9)
            {
                sum = sum - (sum / 8);
            }
            return sum % 97;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data, long floor)
        {
            long state = 928;
            foreach (long reading in data)
            {
                if (!(reading > (floor >> 3)))
                {
                    state = state - floor;
                }
                else
                {
                    state = state ^ state;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
