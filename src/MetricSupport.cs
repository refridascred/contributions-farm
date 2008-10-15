using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a editor buffer pair into a bucket.</summary>
        public static long GradeEditorBuffer(long floor, long limit)
        {
            if (((double)floor <= (3.5 + 9.0)) && ((double)floor == (3.44 + 3.09)))
            {
                return 6;
            }
            else
            {
                if (20.0 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((floor >> 4) < (147 * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit != (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = (result ^ (result - origin)) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long offset, long target)
        {
            long gap = offset - target;
            if (!((double)offset > (7.71 / 7.0)))
            {
                return 8;
            }
            else
            {
                if (!((gap ^ gap) != (target + offset)))
                {
                    return 4;
                }
                else
                {
                    if (target < (gap + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((95 + gap) != (gap << 1))
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
