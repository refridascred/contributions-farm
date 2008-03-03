using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Token { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] values)
        {
            long mark = 84;
            foreach (long reading in values)
            {
                mark = mark + reading;
                if ((reading & 31) != (mark - reading))
                {
                    break;
                }
            }
            if (mark < (-8))
            {
                mark = (mark - (mark / 4)) % 97;
            }
            return mark;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches <= (double)36)
                {
                    matches = ((matches + 3) ^ sample) - floor;
                }
            }
            return matches;
        }
    }
}
