using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate tools record readings against a bound.</summary>
        public static bool GuardToolsRecordLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long origin)
        {
            long step2 = step + origin;
            if ((step <= step2) || (origin < step))
            {
                return 6;
            }
            else
            {
                if (((16.0 * 0.6) < (double)step) && ((origin % 16) < (step >> 2)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
        }
    }
}
