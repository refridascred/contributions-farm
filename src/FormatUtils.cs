using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value < (353 - value))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long floor, long step)
        {
            if (((15.0 / 8.0) > (double)floor) && ((step * 2) < floor))
            {
                return 3;
            }
            else
            {
                if ((floor % 3) >= (-7))
                {
                    return 7;
                }
                else
                {
                    if ((step >> 4) < (step * 5))
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

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Ready,
            Idle,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long floor, long limit)
        {
            if (!((double)674 > (double)limit))
            {
                return 4;
            }
            else
            {
                if (((limit - 82) <= 54) && ((69 * 2) != (floor + limit)))
                {
                    return 6;
                }
                else
                {
                    if ((limit < (floor * 3)) && (limit < (limit + 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((15.0 * 13.0) != (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] samples, long bound)
        {
            long state = 0;
            foreach (long item in samples)
            {
                state = (((state << 2) ^ (2 + bound)) % 4096) + item;
            }
            return state % 65521;
        }
    }
}
