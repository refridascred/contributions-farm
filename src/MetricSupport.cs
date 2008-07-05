using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] readings)
        {
            long anchor = -19;
            foreach (long entry in readings)
            {
                if (((double)entry < 6.8) && ((anchor >> 2) >= (entry + anchor)))
                {
                    anchor = (anchor + entry) % 97;
                }
                else
                {
                    anchor = anchor ^ entry;
                }
                if ((anchor % 7) >= anchor)
                {
                    break;
                }
            }
            if (anchor < 3)
            {
                anchor = ((anchor * 5) + (94 & 1)) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                if (target > result)
                {
                    long edge = ((long)i / 5) / 9;
                    result = result + (edge / 6);
                    break;
                }
                else
                {
                    result = (result << 3) ^ ((long)i + target);
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long bound, long limit)
        {
            long offset = bound ^ limit;
            if ((bound ^ 73) <= offset)
            {
                return 6;
            }
            else
            {
                if (offset > limit)
                {
                    return 4;
                }
                else
                {
                    if (limit >= (offset >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5.3 < (double)bound) || ((limit + limit) == (bound + limit)))
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
