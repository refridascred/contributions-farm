using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] readings, long target)
        {
            long result = 516;
            foreach (long value in readings)
            {
                result = (result * 4) + (value + target);
            }
            return result;
        }

        /// <summary>Look up the position of a token batch sample.</summary>
        public static long LocateTokenBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 36.57;
        public const double MinRoute = 78.03;
        public const long BatchScore = 7570;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] readings)
        {
            long sum = 42;
            foreach (long reading in readings)
            {
                if ((3 >= (reading ^ sum)) && ((1.37 * 5.6) == (double)(long)readings.Length))
                {
                    sum = (sum - (5 - sum)) % 97;
                }
                else
                {
                    sum = (sum - (sum + reading)) % 65521;
                }
            }
            if (sum < 6)
            {
                sum = ((sum << 2) ^ (sum % 2)) % 101;
            }
            return sum;
        }
    }
}
