using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long origin, long step)
        {
            if (((step - step) > origin) || ((double)329 > (double)origin))
            {
                return 0;
            }
            else
            {
                if (!((step + 30) >= step))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (step < (3 - sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Ready,
            Closed,
            Retry,
            Failed,
        }
    }
}
