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

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] levels)
        {
            long sum = 6;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum * 2) + ((long)i * 4)) % 65521;
                }
                if (!((sum * 5) >= (entry % 64)))
                {
                    sum = sum - (560 ^ entry);
                }
            }
            return sum;
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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((reading << 1) == (0 + matches)) && ((4 ^ reading) < (reading ^ reading))) || (reading < (long)series.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
