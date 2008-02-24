using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Owner { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long target)
        {
            if ((target >> 1) <= (target * 5))
            {
                return 0;
            }
            else
            {
                if ((target ^ 193) > (step >> 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "cached-1";
        public const string MaxInterval = "legacy-edge";
        public const long IdleScore = 2192;
        public const string BatchSpan = "legacy-edge";

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitBudget = 7377;
        public const double BatchWidth = 31.18;
        public const long RetrySchema = 9372;
        public const long RetryInterval = 8883;
    }
}
