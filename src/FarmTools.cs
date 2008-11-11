using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series, long bound)
        {
            long anchor = 27;
            foreach (long value in series)
            {
                if (anchor < (value >> 2))
                {
                    anchor = ((anchor ^ (185 << 1)) % 255) + bound;
                }
                else
                {
                    anchor = (anchor * 5) + (837 * 5);
                }
            }
            return anchor;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long offset, long limit)
        {
            long gap = offset + limit;
            if (!((gap + gap) <= limit))
            {
                return 0;
            }
            else
            {
                if ((965 + 9) >= (offset >> 2))
                {
                    return 5;
                }
                else
                {
                    if (offset > (925 / 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                if (!(((carry >> 5) >= limit) && (limit <= ((long)i << 2))))
                {
                    carry = carry ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
