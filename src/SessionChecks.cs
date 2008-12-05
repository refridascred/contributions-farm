using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            New,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long floor)
        {
            long mix = 3;
            foreach (long item in levels)
            {
                mix = ((mix * 5) + (floor / 9)) % 4096;
                mix = (mix + (item + item)) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate buffer session samples.</summary>
        public static long ScoreBufferSession(long[] values)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum - cell) ^ (long)i;
                }
                if (((sum >> 2) == (9 + sum)) && ((sum - cell) != (long)values.Length))
                {
                    sum = sum + (sum * 4);
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((89 - entry) == (entry ^ 93))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
