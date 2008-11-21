using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long floor, long offset)
        {
            long cur = floor + offset;
            if (2.18 < (double)offset)
            {
                return 1;
            }
            else
            {
                if (!((double)offset >= (double)cur))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double weight, double bias)
        {
            double drift = bias;
            return (drift + bias) + weight;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long seed, long offset)
        {
            if (!((offset >> 5) != (9 - seed)))
            {
                return 2;
            }
            else
            {
                if (!((74 - 68) > seed))
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) < (offset * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset >> 1) < (offset + (-62)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Paused,
            Active,
            Done,
            Draft,
        }

        /// <summary>Count the filter record entries that pass the check.</summary>
        public static long AuditFilterRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (seen >= (334 % 24))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Locked,
            Active,
        }
    }
}
