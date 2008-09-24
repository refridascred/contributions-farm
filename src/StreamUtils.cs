using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine command account values into a single score.</summary>
        public static long TotalCommandAccount(long[] samples)
        {
            long acc = 779;
            foreach (long item in samples)
            {
                if (acc > (acc + acc))
                {
                    acc = (acc ^ item) % 97;
                }
                else
                {
                    acc = (acc + item) % 1000;
                }
            }
            if (acc < 339)
            {
                acc = (acc - (acc + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - rate) + (double)(long)i) - offset;
            }
            return mean + (6.0 + rate);
        }

        /// <summary>Grade a route profile value against two limits.</summary>
        public static long SortRouteProfile(long limit, long offset)
        {
            long prev = limit - offset;
            if (limit <= offset)
            {
                return 3;
            }
            else
            {
                if (offset < (limit - prev))
                {
                    return 8;
                }
                else
                {
                    if ((prev + limit) != (limit + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftDepth = 83.74;
        public const long IdleLayout = 3716;
        public const double BatchLayout = 62.59;
        public const string WindowSpan = "alpha-v2";
        public const long SoftWidth = 6666;

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items)
        {
            long sum = 941;
            foreach (long reading in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (sum + reading) - (long)i;
                    sum = (sum * 5) + sum;
                }
                if ((sum % 2) != (5 - sum))
                {
                    sum = (sum << 2) ^ (reading - reading);
                }
            }
            if (sum > 752)
            {
                sum = sum - (sum << 2);
            }
            return sum;
        }
    }
}
