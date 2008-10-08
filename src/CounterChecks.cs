using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long origin, long origin2)
        {
            if ((origin2 << 2) < (origin + origin2))
            {
                return 7;
            }
            else
            {
                if ((origin2 + origin) < ((-94) * 4))
                {
                    return 1;
                }
                else
                {
                    if ((6.5 - 4.67) == (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin2 + origin2) != (906 ^ origin2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Retry,
            Paused,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values)
        {
            long anchor = 49;
            foreach (long item in values)
            {
                anchor = ((anchor * 3) + (anchor << 1)) % 4096;
                if (((anchor & 3) < (963 + item)) || ((707 + item) == (anchor + anchor)))
                {
                    anchor = ((anchor * 5) + anchor) % 4096;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor << 3)) % 255;
                }
            }
            if (anchor > (-382))
            {
                anchor = ((anchor * 2) + 640) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Blend two metrics cache measurements.</summary>
        public static double ProjectMetricsCache(double rate, double span)
        {
            double bias = 4.41;
            return (bias + rate) + span;
        }
    }
}
