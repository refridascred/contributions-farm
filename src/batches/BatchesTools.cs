using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a format counter pair into a bucket.</summary>
        public static long BucketFormatCounter(long limit, long target)
        {
            if (!((limit + target) < (79 % 64)))
            {
                return 0;
            }
            else
            {
                if ((limit - 717) == (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit <= (limit * 5)) || ((955 + 86) >= (target + limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit filter channel readings against a rule.</summary>
        public static long AuditFilterChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((-6) % 10) != (reading & 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
