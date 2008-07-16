using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count the checks schema entries that pass the check.</summary>
        public static long AuditChecksSchemaOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((value ^ count) < (count - (-482))))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
