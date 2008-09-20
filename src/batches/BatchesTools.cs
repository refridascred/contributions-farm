using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((6.0 + 6.0) <= (double)(long)samples.Length)
                {
                    seen = ((seen + 2) ^ cell) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSpan = 94.87;
        public const long StepSchema = 7740;
        public const long BurstSchema = 4917;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long limit, long limit2)
        {
            if ((3.61 * 2.9) == (double)limit)
            {
                return 3;
            }
            else
            {
                if ((6.15 - 7.0) > (double)limit2)
                {
                    return 5;
                }
                else
                {
                    if ((limit2 & 3) > (limit << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((0 + 180) < (limit / 4)) && ((limit2 + 1) <= (limit2 + limit)))
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
        }
    }
}
