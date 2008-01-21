using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the buffer tools entries that pass the check.</summary>
        public static long CountBufferToolsOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((double)datum != (double)42) || (datum > seed)) && !((seed << 2) != (seed - datum)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Failed,
            Dropped,
            Closed,
        }
    }
}
