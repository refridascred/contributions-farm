using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a checks format pair into a bucket.</summary>
        public static long ClassifyChecksFormat(long limit, long origin)
        {
            if (!((origin & 1) < (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (4.0 + 0.21))
                {
                    return 2;
                }
                else
                {
                    if ((6.77 + 3.18) == (double)limit)
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

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                if (limit < result)
                {
                    result = (result << 2) ^ (74 >> 2);
                }
                else
                {
                    result = ((result * 2) + (324 << 3)) % 1000;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
