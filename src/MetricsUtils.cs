using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (8.0 / 5.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long target, long floor)
        {
            if ((target >> 1) >= target)
            {
                return 8;
            }
            else
            {
                if (!((floor + target) > target))
                {
                    return 4;
                }
                else
                {
                    if (target <= (floor + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor > ((-835) - floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every commits stream entry stays within the limit.</summary>
        public static bool VerifyCommitsStreamRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 3) ^ (0 / 3)) % 97;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank report cache input into a small class.</summary>
        public static long GradeReportCache(long floor, long offset)
        {
            if ((double)offset >= (7.35 - 5.3))
            {
                return 6;
            }
            else
            {
                if ((7.26 + 5.9) < (double)offset)
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
