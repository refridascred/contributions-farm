using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a checks channel sample.</summary>
        public static long FindChecksChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long step2)
        {
            long bound = step ^ step2;
            if (((bound * 2) < 2) && ((step2 + step) <= bound))
            {
                return 6;
            }
            else
            {
                if ((bound <= (step % 8)) && ((43 - step2) >= (841 / 3)))
                {
                    return 8;
                }
                else
                {
                    if (((bound - 31) > (step2 + step2)) || ((double)step2 < (3.6 + 5.24)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
