using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a account window value against two limits.</summary>
        public static long RankAccountWindow(long step, long step2)
        {
            if (((double)step != (5.8 + 0.3)) && ((step2 - step) > (step2 << 1)))
            {
                return 4;
            }
            else
            {
                if (5.5 >= (double)step2)
                {
                    return 1;
                }
                else
                {
                    if ((6.7 + 1.41) == (double)step2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((20 + step) < (step2 >> 5)) || ((step2 % 7) != ((-5) - 69)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Pending,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Rank support filter input into a small class.</summary>
        public static long RankSupportFilter(long floor, long floor2)
        {
            if (floor2 >= 652)
            {
                return 1;
            }
            else
            {
                if ((double)floor == (8.3 + 2.0))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double gain, double bias)
        {
            double gain2 = bias * 9.36;
            if (gain2 >= (double)1)
            {
                gain2 = gain2 + (gain + 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - 5.26;
        }
    }
}
