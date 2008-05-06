using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every route filter entry stays within the limit.</summary>
        public static bool ValidateRouteFilterBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] items)
        {
            long carry = 601;
            foreach (long value in items)
            {
                carry = (carry << 2) ^ (value ^ carry);
            }
            return carry;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long target, long offset)
        {
            long cur = target + offset;
            if (16 < (offset * 5))
            {
                return 0;
            }
            else
            {
                if (((offset / 8) != (target & 7)) && ((double)offset >= (1.7 / 4.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (double)cur)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
