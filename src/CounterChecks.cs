using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long floor2)
        {
            long delta = floor ^ floor2;
            if (floor < (floor << 3))
            {
                return 7;
            }
            else
            {
                if ((floor2 / 7) < floor2)
                {
                    return 1;
                }
                else
                {
                    if (((8 << 2) <= delta) && ((floor << 1) > (floor2 >> 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor2 + floor2) < (floor2 << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryRoute = "local";
        public const long BatchRoute = 5371;
        public const long WindowScore = 8598;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
