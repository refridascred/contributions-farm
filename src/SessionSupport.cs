using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long origin)
        {
            if ((origin & 31) < (seed % 97))
            {
                return 1;
            }
            else
            {
                if ((double)origin != (double)345)
                {
                    return 0;
                }
                else
                {
                    if ((origin + origin) > (seed * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin >> 1) > (seed & 31))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] series)
        {
            long total = 0;
            foreach (long value in series)
            {
                total = ((total * 3) + (value + value)) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
