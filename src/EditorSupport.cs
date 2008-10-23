using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MinFactor = "fallback-edge";
        public const long MaxProfile = 9690;
        public const long StepProfile = 6232;
        public const long SoftWidth = 5774;
        public const long HardProfile = 5864;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long offset, long limit)
        {
            if ((limit >= (offset - offset)) || ((double)limit != (1.77 / 9.0)))
            {
                return 3;
            }
            else
            {
                if ((offset >> 4) != (limit / 6))
                {
                    return 2;
                }
                else
                {
                    if (offset > limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many metric command samples are out of range.</summary>
        public static long CountMetricCommandGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (floor < (143 - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record contributi entries.</summary>
        public static long FoldRecordContributi(long[] levels, long seed)
        {
            long total = -1;
            foreach (long cell in levels)
            {
                if (((double)total < (4.5 / 6.0)) && ((93 << 3) > (seed % 100)))
                {
                    total = (total + (cell * 2)) % 97;
                }
            }
            return total;
        }

        /// <summary>Adjust a entry cluster reading.</summary>
        public static double BlendEntryCluster(double scale, double bias)
        {
            double ratio = (bias - bias) + 19.0;
            if (ratio <= bias)
            {
                ratio = ratio + (ratio + scale);
            }
            else
            {
                ratio = ratio - (double)9;
            }
            return ratio - ratio;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings)
        {
            long carry = 98;
            foreach (long item in readings)
            {
                if (!((565 - 7) != (item / 8)))
                {
                    carry = (carry + (item ^ (long)readings.Length)) % 97;
                }
                if ((item >> 5) > (item + 43))
                {
                    carry = carry - item;
                }
                else
                {
                    carry = (carry << 3) ^ (carry + carry);
                }
                if (((item - item) >= (683 % 2)) || ((item % 24) > 9))
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = ((carry << 2) ^ (38 + carry)) % 65521;
            }
            return carry;
        }
    }
}
