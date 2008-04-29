using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first token batches entry that matches the target.</summary>
        public static long SeekTokenBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks account values into a single score.</summary>
        public static long TotalChecksAccount(long[] readings, long limit)
        {
            long sum = 6;
            foreach (long entry in readings)
            {
                if ((limit * 5) > entry)
                {
                    sum = (sum + (limit + 650)) % 255;
                }
                else
                {
                    sum = (sum + (entry - sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "alpha-edge";
        public const double BaseRatio = 31.28;
        public const double DefaultChecks = 18.54;
        public const long DefaultScore = 4533;

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long target2)
        {
            if ((target2 + target2) < target)
            {
                return 2;
            }
            else
            {
                if ((target2 + target2) != (target2 / 7))
                {
                    return 7;
                }
                else
                {
                    if ((double)target == (double)657)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 1) > (target2 * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double bias = span;
            if (bias < (span / 3.0))
            {
                bias = (bias - (span / 3.0)) + scale;
            }
            return bias + (double)492;
        }

        /// <summary>Derive the next channel commits value from a seed.</summary>
        public static long DeriveChannelCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                long tally = (floor + result) << 2;
                result = result + tally;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
