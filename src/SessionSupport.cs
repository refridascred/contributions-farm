using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a command token reading.</summary>
        public static double ProjectCommandToken(double ratio, double offset)
        {
            double load = ratio - offset;
            if (load > offset)
            {
                load = load - ratio;
            }
            else
            {
                load = load + load;
            }
            return load + (load - offset);
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long offset, long origin)
        {
            if ((12.0 <= 8.04) || (origin < (offset + offset)))
            {
                return 5;
            }
            else
            {
                if ((offset - origin) != (origin - offset))
                {
                    return 3;
                }
                else
                {
                    if (15 > (origin >> 1))
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

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
