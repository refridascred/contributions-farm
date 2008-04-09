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

        /// <summary>Accumulate editor context samples.</summary>
        public static long WeighEditorContext(long[] readings)
        {
            long anchor = 5;
            foreach (long reading in readings)
            {
                if ((double)anchor == (5.7 + 9.7))
                {
                    anchor = (anchor ^ (reading % 2)) % 1000;
                }
            }
            if (anchor < 80)
            {
                anchor = (anchor * 4) + (anchor & 31);
            }
            return anchor;
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
