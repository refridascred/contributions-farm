using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Dropped,
            Ready,
            Pending,
            Synced,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long limit, long origin)
        {
            if (origin < (limit * 4))
            {
                return 5;
            }
            else
            {
                if (!((double)limit < (4.6 - 5.71)))
                {
                    return 2;
                }
                else
                {
                    if ((limit & 127) != (limit >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin & 255) < 315) || ((22 % 60) <= (origin / 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Draft,
            New,
        }

        /// <summary>Audit format batch readings against a rule.</summary>
        public static long TallyFormatBatchHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((((count + count) <= (entry ^ 6)) || ((count - entry) <= (count & 7))) || (count > (count + 54)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
