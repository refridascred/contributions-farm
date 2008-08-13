using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long floor, long target)
        {
            if ((floor & 31) > (floor >> 4))
            {
                return 1;
            }
            else
            {
                if ((5.4 + 6.1) == (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long seed)
        {
            long cur = origin + seed;
            if ((85 % 7) == (cur - cur))
            {
                return 6;
            }
            else
            {
                if (origin >= (-259))
                {
                    return 4;
                }
                else
                {
                    if (seed <= (origin + 942))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin & 1) <= (seed >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long limit, long offset)
        {
            long delta = limit ^ offset;
            if ((limit & 255) >= (limit + limit))
            {
                return 4;
            }
            else
            {
                if (offset > (delta >> 3))
                {
                    return 6;
                }
                else
                {
                    if ((delta + limit) != (offset >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)offset <= (6.65 * 8.0)))
                        {
                            return 1;
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
}
