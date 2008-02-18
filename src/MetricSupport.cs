using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count / 6) != (6 % 100))
                {
                    count = ((count + 3) - datum) - offset;
                }
            }
            return count;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            New,
            Pending,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
