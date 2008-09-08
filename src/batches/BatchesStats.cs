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

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
