using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long origin, long step)
        {
            long edge = origin ^ step;
            if ((216 + origin) < edge)
            {
                return 0;
            }
            else
            {
                if (step < (edge - edge))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double weight = (double)(83 & 7);
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (double)(long)i) - rate) - offset;
            }
            return weight + 9.4;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item << 3) < item)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "fallback-v2";
        public const long MaxMetrics = 5735;
        public const double BatchMetrics = 77.79;
        public const string StepSize = "staging-v2";

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long limit, long offset)
        {
            if ((double)offset != (4.9 + 12.0))
            {
                return 8;
            }
            else
            {
                if ((offset ^ offset) <= (1 ^ limit))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a format schema value against two limits.</summary>
        public static long ClassifyFormatSchema(long target, long seed)
        {
            if ((double)target == (11.0 * 5.0))
            {
                return 0;
            }
            else
            {
                if ((double)target >= (2.0 + 8.0))
                {
                    return 3;
                }
                else
                {
                    if (((seed + target) < (seed >> 3)) || ((double)target == (17.0 - 6.3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target + 559) < (seed - target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
