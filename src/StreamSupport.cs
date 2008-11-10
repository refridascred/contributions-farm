using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Closed,
            Paused,
            Locked,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                if (!(((82 + target) < 73) || ((double)target != (double)6)))
                {
                    mark = (mark - (long)i) % 101;
                    mark = mark - (target + (long)i);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
