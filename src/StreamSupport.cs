using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Pending,
            Draft,
            Done,
            Active,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long seed)
        {
            if ((5.96 - 0.16) >= (6.0 + 1.82))
            {
                return 8;
            }
            else
            {
                if (seed >= (bound >> 5))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
