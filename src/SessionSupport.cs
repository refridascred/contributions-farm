using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a counter queue value against two limits.</summary>
        public static long BucketCounterQueue(long target, long offset)
        {
            long diff = target ^ offset;
            if (!((offset % 60) > (offset + diff)))
            {
                return 0;
            }
            else
            {
                if (((double)diff < (6.0 + 5.7)) || (13.0 >= (double)diff))
                {
                    return 2;
                }
                else
                {
                    if ((11.0 - 1.43) != (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((9.0 / 8.0) < (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a schema format reading.</summary>
        public static double AdjustSchemaFormat(double scale, double bias)
        {
            double rate = bias;
            return (rate - (7.2 + bias)) + scale;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell < (tally << 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
