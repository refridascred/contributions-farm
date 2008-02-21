using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Dropped,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Project the next metric stats value.</summary>
        public static double AdjustMetricStats(double bias, double floor)
        {
            double mean = (double)(154 % 2);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + floor) + (double)(long)i) + bias;
            }
            return mean - (floor - floor);
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Closed,
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Grade a contributi checks value against two limits.</summary>
        public static long ClassifyContributiChecks(long floor, long limit)
        {
            if ((floor - 94) < (floor - floor))
            {
                return 7;
            }
            else
            {
                if (limit <= (limit / 7))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit <= 2.1)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor == (5.7 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
