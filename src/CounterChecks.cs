using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Active,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally >= entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] items, long floor)
        {
            long sum = 3;
            foreach (long entry in items)
            {
                sum = (sum << 2) ^ floor;
                sum = sum ^ (floor + entry);
                if (!(770 < ((-660) + entry)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] values, long limit)
        {
            long acc = 909;
            foreach (long item in values)
            {
                if (limit <= (limit + acc))
                {
                    acc = (acc * 4) + 16;
                }
                if (((limit % 5) == (item + item)) || ((item / 6) >= (limit + acc)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
