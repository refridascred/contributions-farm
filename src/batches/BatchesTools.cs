using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 4593;
        public const long SoftAlready = 194;
        public const long BaseSize = 5344;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample + (-84)) <= (origin - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long limit, long target)
        {
            if ((target + target) <= (target + limit))
            {
                return 5;
            }
            else
            {
                if ((target << 3) != (target * 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)target < 6.42)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
