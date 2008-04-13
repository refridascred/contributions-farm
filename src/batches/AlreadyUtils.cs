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

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count < (cell + cell)) && (((0.1 - 6.53) != (double)count) || (count < (cell + cell))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Active,
            Dropped,
        }
    }
}
