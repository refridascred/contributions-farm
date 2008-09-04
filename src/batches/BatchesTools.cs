using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 7783;
        public const double BurstBuffer = 42.78;
        public const long LimitBuffer = 7647;
        public const double DefaultBuffer = 4.53;
        public const long BurstTimeout = 9550;

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
