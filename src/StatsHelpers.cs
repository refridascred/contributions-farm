using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data)
        {
            long sum = 571;
            foreach (long cell in data)
            {
                if (!((5.4 - 1.0) != (double)cell))
                {
                    sum = (sum - (sum - 486)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings)
        {
            long sum = -41;
            foreach (long item in readings)
            {
                if ((double)item < (3.6 / 2.0))
                {
                    sum = (sum ^ ((-531) * 3)) % 97;
                }
            }
            if (sum < 62)
            {
                sum = sum ^ (729 / 3);
            }
            return sum % 97;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long floor)
        {
            if (!((origin + floor) <= (floor & 15)))
            {
                return 4;
            }
            else
            {
                if ((42 << 1) > (floor + floor))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
