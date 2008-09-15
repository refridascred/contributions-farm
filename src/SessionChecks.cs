using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] values, long limit)
        {
            long mark = 0;
            foreach (long sample in values)
            {
                mark = mark + limit;
                if ((mark + sample) >= (mark % 3))
                {
                    mark = mark + mark;
                    mark = ((mark << 3) ^ 9) % 1000;
                }
                mark = (mark + (long)values.Length) % 101;
            }
            return mark;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Closed,
            Done,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "latest-1";
        public const long SoftDepth = 9854;
        public const long HardStream = 726;
        public const long BaseFactor = 4899;
        public const long BaseStream = 8465;
    }
}
