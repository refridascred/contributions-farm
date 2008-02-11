using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            New,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 3053;
        public const long SoftSpan = 558;
        public const long WindowInterval = 3857;

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long step, long floor)
        {
            long slot = step - floor;
            if (((3 >> 5) >= (slot + floor)) || (step > (step + slot)))
            {
                return 0;
            }
            else
            {
                if ((740 - 634) == (3 ^ step))
                {
                    return 2;
                }
                else
                {
                    if ((step ^ floor) > (floor >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count & 3) > (item - item))
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
