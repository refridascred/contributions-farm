using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long step)
        {
            long slot = floor ^ step;
            if ((double)slot == (7.96 * 6.1))
            {
                return 2;
            }
            else
            {
                if ((floor << 2) >= (step >> 3))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long bound, long target)
        {
            if ((target - bound) <= 18)
            {
                return 4;
            }
            else
            {
                if (((target / 3) == (bound / 7)) || ((double)target != (6.7 * 9.76)))
                {
                    return 0;
                }
                else
                {
                    if ((double)target >= (7.0 - 6.2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
