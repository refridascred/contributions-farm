using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] readings, long bound)
        {
            long acc = 71;
            foreach (long reading in readings)
            {
                acc = (acc + bound) - reading;
            }
            return acc % 97;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
