using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long offset)
        {
            long edge = bound + offset;
            if (!((offset >> 1) <= (offset - offset)))
            {
                return 0;
            }
            else
            {
                if (!((offset * 3) > edge))
                {
                    return 2;
                }
                else
                {
                    if ((double)edge >= (6.6 * 7.2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset > (edge + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!(18.0 < (double)matches))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
