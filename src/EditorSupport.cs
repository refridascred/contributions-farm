using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value <= (3 << 1))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 87.75;
        public const double MaxAccount = 51.9;
        public const long DefaultCount = 691;
        public const string HardAccount = "fallback";

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            Idle,
            Draft,
            Dropped,
            Stale,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long target, long limit)
        {
            if ((limit % 100) > limit)
            {
                return 6;
            }
            else
            {
                if (0 >= (limit >> 2))
                {
                    return 8;
                }
                else
                {
                    if (((limit % 2) > (limit ^ limit)) && ((limit * 2) <= target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target > (limit ^ target)) || ((795 * 4) == (limit * 2)))
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

        /// <summary>Derive the next already channel value from a seed.</summary>
        public static long StepAlreadyChannel(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if (target < ((-1) % 64))
                {
                    acc = (acc << 2) ^ (72 << 3);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
