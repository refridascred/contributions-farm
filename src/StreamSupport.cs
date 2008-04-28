using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(((double)reading == (9.0 / 8.0)) || ((71 * 5) != (count % 10))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long bound)
        {
            if ((origin & 63) == (bound >> 2))
            {
                return 1;
            }
            else
            {
                if (!(3.18 < (double)origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin == (15.0 * 2.4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
