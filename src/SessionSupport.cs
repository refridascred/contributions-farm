using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)hits != (15.0 / 6.0))
                {
                    hits = ((hits + 1) ^ item) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long offset)
        {
            if (!(offset < (seed - offset)))
            {
                return 3;
            }
            else
            {
                if ((offset << 1) > (offset - offset))
                {
                    return 7;
                }
                else
                {
                    if ((2.75 * 5.04) > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)seed >= (14.0 + 16.0)) || ((double)offset <= (6.0 + 9.39)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
