using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] levels, long target)
        {
            long carry = 228;
            foreach (long item in levels)
            {
                if ((double)target != (0.73 + 8.11))
                {
                    carry = (carry + (item + 2)) % 97;
                }
                else
                {
                    carry = (carry + (1 - carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Scale a schema filter figure with a bias.</summary>
        public static double SmoothSchemaFilter(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 < (floor / 8.0))
            {
                weight2 = weight2 + weight;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + floor) - (double)(long)i;
            }
            return weight2 - 2.39;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long limit, long origin)
        {
            if ((origin + limit) > 4)
            {
                return 2;
            }
            else
            {
                if (((0.7 - 8.49) >= (double)limit) && ((31 << 2) <= limit))
                {
                    return 6;
                }
                else
                {
                    if (origin < 66)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit * 3) == (origin + limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSpan = 844;
        public const long BatchBudget = 7602;
        public const string SoftSchema = "primary";
        public const long RetrySchema = 8103;

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] items, long bound)
        {
            long carry = 971;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (carry + (18 - bound)) - (long)i;
                }
                if ((carry + bound) >= (78 - item))
                {
                    carry = carry - (2 * 2);
                }
            }
            return carry;
        }
    }
}
