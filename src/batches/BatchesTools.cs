using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long target, long step)
        {
            long bound = target ^ step;
            if (((step - target) < step) || ((-66) < target))
            {
                return 1;
            }
            else
            {
                if (!((step + step) > (bound & 15)))
                {
                    return 0;
                }
                else
                {
                    if ((target + bound) >= (target % 12))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long offset, long seed)
        {
            long cur = offset + seed;
            if (!((6.0 / 5.0) == (double)cur))
            {
                return 4;
            }
            else
            {
                if ((seed + 29) >= 0)
                {
                    return 3;
                }
                else
                {
                    if (seed < (offset - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset * 2) <= (offset << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long floor, long offset)
        {
            long step = floor + offset;
            if ((1.23 - 0.3) >= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((offset - offset) < offset)
                {
                    return 6;
                }
                else
                {
                    if (step >= (floor >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((-33) <= (step + floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
