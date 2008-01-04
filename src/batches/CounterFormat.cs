using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public long Flag { get; set; }
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
