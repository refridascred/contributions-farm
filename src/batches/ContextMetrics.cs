using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a payload route pair into a bucket.</summary>
        public static long ClassifyPayloadRoute(long offset, long target)
        {
            if (!((offset + offset) >= (23 % 5)))
            {
                return 4;
            }
            else
            {
                if (!((double)offset > (20.0 * 5.7)))
                {
                    return 5;
                }
                else
                {
                    if ((offset >= (target % 5)) && ((offset << 3) > 195))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target << 3) <= (offset * 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftScore = "cached-1";
        public const long WindowEditor = 4503;
        public const long WindowSpan = 7690;
        public const long BatchEditor = 2021;
        public const long MaxSpan = 9269;

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long bound, long offset)
        {
            long cur = bound - offset;
            if (!((double)cur >= (double)offset))
            {
                return 7;
            }
            else
            {
                if ((5.8 + 1.58) < (double)cur)
                {
                    return 0;
                }
                else
                {
                    if (!(cur <= offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (4 >= (cur & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine contributi schema values into a single score.</summary>
        public static long WeighContributiSchema(long[] data)
        {
            long total = -2;
            foreach (long value in data)
            {
                if ((total + value) < 41)
                {
                    total = ((total << 2) ^ (total << 2)) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Roll a profile batch counter forward.</summary>
        public static long SeriesProfileBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
