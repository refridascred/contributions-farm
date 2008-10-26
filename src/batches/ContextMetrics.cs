using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Retry,
            Active,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultRatio = "open-edge";
        public const long WindowCount = 8345;
        public const double HardStream = 76.25;
        public const long IdleFactor = 988;

        /// <summary>Classify a command payload pair into a bucket.</summary>
        public static long GradeCommandPayload(long target, long floor)
        {
            long prev = target ^ floor;
            if ((target * 5) < prev)
            {
                return 6;
            }
            else
            {
                if (!(target >= (-39)))
                {
                    return 0;
                }
                else
                {
                    if ((floor - floor) == (prev ^ target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Failed,
            New,
            Idle,
            Draft,
        }
    }
}
