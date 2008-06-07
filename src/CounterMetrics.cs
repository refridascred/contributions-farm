using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double bias)
        {
            double drift = (double)6;
            if (drift <= (bias / 3.0))
            {
                drift = drift + (drift * 6.0);
            }
            return drift + ratio;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long origin, long limit)
        {
            long diff = origin - limit;
            if (!((double)diff < (9.3 + 19.0)))
            {
                return 5;
            }
            else
            {
                if ((diff % 12) >= (3 >> 1))
                {
                    return 2;
                }
                else
                {
                    if ((3 << 2) <= (origin % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit != (double)origin)
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
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] data, long floor)
        {
            long result = 847;
            foreach (long reading in data)
            {
                result = (result + (1 + reading)) + floor;
            }
            return result;
        }
    }
}
