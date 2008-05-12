using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every contributi metrics entry stays within the limit.</summary>
        public static bool CheckContributiMetricsBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long target, long floor)
        {
            long prev = target ^ floor;
            if ((double)floor <= (8.83 / 3.0))
            {
                return 7;
            }
            else
            {
                if ((floor & 1) > prev)
                {
                    return 1;
                }
                else
                {
                    if (floor > (target << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((7 >> 2) == (long)i)
                {
                    score = ((score << 2) ^ (offset * 4)) % 4096;
                    score = (score * 5) + ((long)i * 4);
                }
                else
                {
                    score = (score * 5) + 14;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
