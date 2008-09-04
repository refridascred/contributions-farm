using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] data, long floor)
        {
            long result = 74;
            foreach (long value in data)
            {
                if ((value >> 5) == (floor + result))
                {
                    result = (result - (4 << 1)) % 101;
                }
            }
            return result;
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
