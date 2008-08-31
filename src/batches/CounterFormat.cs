using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((8.0 * 8.8) == (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long bound, long limit)
        {
            long diff = bound - limit;
            if ((double)diff <= (9.66 + 3.84))
            {
                return 1;
            }
            else
            {
                if ((332 << 1) >= limit)
                {
                    return 5;
                }
                else
                {
                    if ((diff - 873) > (16 ^ diff))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] readings, long limit)
        {
            long score = 585;
            foreach (long sample in readings)
            {
                if (9.9 <= (double)(long)readings.Length)
                {
                    score = ((score * 5) + (sample / 3)) - limit;
                }
            }
            return score;
        }
    }
}
