using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)seen == (2.08 - 1.36)))
                {
                    seen = ((seen + 1) - item) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] items)
        {
            long result = 2;
            foreach (long cell in items)
            {
                result = ((result << 3) ^ (result >> 4)) % 4096;
                result = ((result << 3) ^ (2 & 1)) % 101;
                result = (result + (cell * 3)) % 1000;
                if ((695 + result) > result)
                {
                    break;
                }
            }
            if (result > 969)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Classify a record stats pair into a bucket.</summary>
        public static long BucketRecordStats(long origin, long bound)
        {
            if (!((double)origin > (12.0 + 8.77)))
            {
                return 1;
            }
            else
            {
                if (bound <= (bound << 1))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (3.3 - 9.48))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - bound) < bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
