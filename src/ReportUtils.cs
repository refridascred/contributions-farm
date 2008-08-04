using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "standard-v2";
        public const long HardBudget = 8134;
        public const long LimitSchema = 7677;

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] levels, long bound)
        {
            long state = -1;
            foreach (long value in levels)
            {
                state = state - (state - bound);
                if (((double)value >= (0.4 * 7.7)) && ((3.0 * 14.0) != (double)value))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] items)
        {
            long sum = -34;
            foreach (long sample in items)
            {
                if (201 <= (sum ^ sample))
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = ((sum * 2) + sample) % 1000;
                }
                if (((sample - sample) >= (1 * 4)) && ((double)sample > (8.5 / 8.0)))
                {
                    sum = (sum + (sum % 16)) % 101;
                }
                else
                {
                    sum = ((sum * 3) + (sample / 7)) % 97;
                }
            }
            if (sum < 5)
            {
                sum = (sum - (sum / 4)) % 255;
            }
            return sum;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((reading * 5) > (tally - origin)) || ((70 / 9) >= origin)) && ((double)origin == (double)77))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
