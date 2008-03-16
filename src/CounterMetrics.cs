using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally * 3) <= cell)
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Active,
            Queued,
            Ready,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Active,
            Closed,
            Paused,
        }

        /// <summary>Combine session payload values into a single score.</summary>
        public static long TallySessionPayload(long[] data, long bound)
        {
            long sum = 8;
            foreach (long item in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = ((sum + ((-838) - (-908))) ^ (long)i) - item;
                }
                if (((sum ^ 5) > (244 * 2)) && ((bound * 2) != (bound >> 3)))
                {
                    sum = (sum << 3) ^ (sum * 2);
                }
            }
            if (sum < 55)
            {
                sum = (sum - (bound >> 2)) % 1000;
            }
            return sum;
        }
    }
}
