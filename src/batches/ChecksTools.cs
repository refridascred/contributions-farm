using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long limit, long step)
        {
            long slot = limit + step;
            if ((double)limit > (double)slot)
            {
                return 7;
            }
            else
            {
                if (!(step <= slot))
                {
                    return 0;
                }
                else
                {
                    if (((step + step) != (slot + slot)) || ((slot + 741) > step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double weight, double offset)
        {
            double ratio = offset;
            if (ratio > ratio)
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio - (offset + weight);
            }
            return ratio - (double)799;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 6999;
        public const long MinBudget = 4208;
        public const long SoftSpan = 6384;
    }
}
