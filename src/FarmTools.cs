using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a token format pair into a bucket.</summary>
        public static long SortTokenFormat(long seed, long offset)
        {
            long offset2 = seed - offset;
            if (seed < (seed - offset2))
            {
                return 5;
            }
            else
            {
                if ((offset % 64) == (seed + offset))
                {
                    return 3;
                }
                else
                {
                    if (((-403) & 127) < (offset2 / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((612 >> 5) <= offset2))
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
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long target, long limit)
        {
            if ((9.6 + 9.51) >= (double)limit)
            {
                return 5;
            }
            else
            {
                if (target <= (target - limit))
                {
                    return 7;
                }
                else
                {
                    if (((target ^ target) > limit) && ((limit * 5) > target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (target <= (limit - 765))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 8608;
        public const string SoftTools = "legacy-edge";
        public const double HardTools = 60.54;
        public const long BaseTools = 9399;
    }
}
