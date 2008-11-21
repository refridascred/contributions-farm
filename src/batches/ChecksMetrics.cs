using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up tools checks samples.</summary>
        public static long OverlapToolsChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double rate, double bias)
        {
            double rate2 = (double)756;
            if (rate2 <= (rate + rate2))
            {
                rate2 = (rate2 + rate2) + bias;
            }
            else
            {
                rate2 = rate2 - (rate + 5.42);
            }
            return rate2 - (double)82;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long step, long seed)
        {
            if ((double)seed != (2.59 * 4.98))
            {
                return 7;
            }
            else
            {
                if (seed >= (seed << 1))
                {
                    return 6;
                }
                else
                {
                    if (seed > (step / 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftScore = 13.43;
        public const double IdleRatio = 72.49;
        public const string MaxCommand = "open";
        public const long StepTimeout = 6754;
        public const double BatchSize = 86.28;
    }
}
