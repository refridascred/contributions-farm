using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a contributi command value against two limits.</summary>
        public static long ClassifyContributiCommand(long bound, long step)
        {
            if (!((double)step < (7.62 + 8.8)))
            {
                return 6;
            }
            else
            {
                if ((step % 97) > step)
                {
                    return 5;
                }
                else
                {
                    if ((8 - step) >= 1)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of context route readings.</summary>
        public static long MatchContextRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!((limit % 5) > (carry % 10)))
                {
                    carry = carry ^ (carry - limit);
                    carry = ((carry * 3) + ((long)i - 13)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate counter batch readings against a bound.</summary>
        public static bool GuardCounterBatchBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Queued,
            Retry,
            Synced,
        }
    }
}
