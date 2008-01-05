using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a command contributi reading by value.</summary>
        public static long LookupCommandContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long target, long origin)
        {
            if ((double)origin <= 3.52)
            {
                return 3;
            }
            else
            {
                if ((double)origin > (double)8)
                {
                    return 6;
                }
                else
                {
                    if (6.8 < (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) <= (hits << 1))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }
    }
}
