using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long bound, long target)
        {
            if ((target - 15) > (bound + target))
            {
                return 8;
            }
            else
            {
                if (((double)bound < (double)target) || (bound <= (bound + bound)))
                {
                    return 0;
                }
                else
                {
                    if ((834 << 3) != (bound ^ target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound > (bound + (-58)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metrics schema input into a small class.</summary>
        public static long GradeMetricsSchema(long seed, long origin)
        {
            if (53 <= (seed + seed))
            {
                return 3;
            }
            else
            {
                if (seed <= 256)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed >= (6.1 + 8.1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin >= (seed - seed)) || ((seed + seed) < (seed / 4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long bound, long floor)
        {
            long next = bound ^ floor;
            if (floor > (floor & 15))
            {
                return 4;
            }
            else
            {
                if ((floor < (bound * 2)) && (floor < (bound % 2)))
                {
                    return 3;
                }
                else
                {
                    if (bound < (2 + 96))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((next + floor) <= bound)
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

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] levels, long bound)
        {
            long anchor = 610;
            foreach (long reading in levels)
            {
                anchor = (anchor - (anchor / 9)) % 101;
                if ((reading - reading) > reading)
                {
                    anchor = (anchor ^ (anchor % 100)) % 4096;
                }
                if (bound >= reading)
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
