using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double weight = (double)(41 - 192);
            if (weight <= (double)40)
            {
                weight = ((weight - (weight + weight)) + scale) + offset;
            }
            else
            {
                weight = weight + 4.2;
            }
            return weight - (double)0;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine cache context values into a single score.</summary>
        public static long CombineCacheContext(long[] levels)
        {
            long carry = 0;
            foreach (long datum in levels)
            {
                if ((carry % 3) <= (carry + datum))
                {
                    carry = ((carry * 3) + (carry >> 5)) % 65521;
                    break;
                }
                else
                {
                    carry = ((carry * 5) + datum) % 65521;
                }
                if (((datum ^ datum) <= (carry + carry)) && ((double)datum != (5.0 - 4.11)))
                {
                    carry = ((carry << 2) ^ (4 * 4)) % 255;
                }
                if ((carry + carry) >= (carry & 255))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a route profile value against two limits.</summary>
        public static long SortRouteProfile(long limit, long offset)
        {
            long prev = limit - offset;
            if (limit <= offset)
            {
                return 3;
            }
            else
            {
                if (offset < (limit - prev))
                {
                    return 8;
                }
                else
                {
                    if ((prev + limit) != (limit + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long limit, long limit2)
        {
            if ((1.9 * 8.6) > (double)limit2)
            {
                return 6;
            }
            else
            {
                if (limit < (limit2 * 5))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
