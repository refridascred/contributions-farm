using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long target, long floor)
        {
            if ((3 + 569) < (target & 3))
            {
                return 7;
            }
            else
            {
                if ((67 << 1) != (floor / 7))
                {
                    return 3;
                }
                else
                {
                    if (((floor - floor) >= (target - floor)) && ((776 & 255) > target))
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

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long step, long origin)
        {
            if (origin <= (step * 4))
            {
                return 1;
            }
            else
            {
                if ((origin << 3) >= (234 - step))
                {
                    return 6;
                }
                else
                {
                    if (((777 & 31) <= (step & 1)) && ((6.39 - 20.0) == (double)step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(9.45 <= (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowSpan = 78.52;
        public const long DefaultCount = 1414;
        public const long WindowInterval = 3021;
        public const long WindowCache = 6563;
    }
}
