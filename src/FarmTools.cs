using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] samples, long target)
        {
            long mark = 219;
            foreach (long value in samples)
            {
                if ((69 / 3) > (mark - target))
                {
                    mark = ((mark * 5) + target) % 4096;
                }
                else
                {
                    mark = (mark + (value & 3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Combine report support values into a single score.</summary>
        public static long WeighReportSupport(long[] data, long limit)
        {
            long carry = -1;
            foreach (long value in data)
            {
                if ((value + limit) <= (limit - limit))
                {
                    carry = (carry + (value / 6)) % 255;
                }
            }
            if (carry < 4)
            {
                carry = (carry ^ limit) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long bound, long limit)
        {
            if ((bound & 31) < 81)
            {
                return 7;
            }
            else
            {
                if (limit < ((-92) + limit))
                {
                    return 8;
                }
                else
                {
                    if (limit <= (71 >> 3))
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
}
