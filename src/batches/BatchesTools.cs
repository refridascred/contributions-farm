using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long offset)
        {
            if ((offset - offset) == (target >> 1))
            {
                return 6;
            }
            else
            {
                if ((755 + offset) == (target + target))
                {
                    return 4;
                }
                else
                {
                    if ((target * 5) < (target - target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((4.5 / 7.0) > (double)target) && ((target + offset) >= (offset + 9)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = total ^ (offset + total);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
