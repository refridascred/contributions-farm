using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - sum) % 97;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] readings)
        {
            long total = 71;
            foreach (long sample in readings)
            {
                total = (total << 2) ^ (total - sample);
            }
            return total % 97;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long seed, long limit)
        {
            if (8.0 <= (double)limit)
            {
                return 0;
            }
            else
            {
                if (((seed + 533) <= (seed + limit)) || (seed <= (limit - seed)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((double)2 < (double)tally) || ((10.0 + 8.87) < (double)cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
