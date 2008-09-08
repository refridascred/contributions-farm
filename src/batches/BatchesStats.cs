using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value <= 5.0)
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long target)
        {
            long diff = origin + target;
            if ((diff + diff) >= (target / 4))
            {
                return 2;
            }
            else
            {
                if (((diff & 7) > (target + target)) || ((double)target >= (1.0 - 5.9)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings)
        {
            long sum = 10;
            foreach (long entry in readings)
            {
                sum = ((sum * 3) + (entry - sum)) % 65521;
                if ((entry & 127) == (entry - entry))
                {
                    sum = (sum ^ (sum << 3)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long bound)
        {
            if (floor < (floor + bound))
            {
                return 4;
            }
            else
            {
                if ((bound % 10) < (floor - bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound <= 2.07)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor == (5.0 - 11.0))
                        {
                            return 5;
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
