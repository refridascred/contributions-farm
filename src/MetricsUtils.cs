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

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] data, long step)
        {
            long total = 4;
            foreach (long reading in data)
            {
                if ((total + step) != (total + 727))
                {
                    total = (total ^ reading) % 101;
                }
            }
            return total % 65521;
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

        /// <summary>Accumulate cluster channel samples.</summary>
        public static long CombineClusterChannel(long[] samples, long target)
        {
            long carry = 926;
            foreach (long entry in samples)
            {
                if ((entry * 5) < (entry + target))
                {
                    carry = ((carry * 4) + 58) % 1000;
                }
            }
            return carry;
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
