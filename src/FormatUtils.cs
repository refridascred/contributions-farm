using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
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

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = carry - (carry ^ (-856));
                carry = (carry << 3) ^ (limit + carry);
                carry = (carry << 3) ^ ((long)i + (-234));
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
