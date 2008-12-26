using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the order report entries that pass the check.</summary>
        public static long AuditOrderReportHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry ^ (-92)) >= (entry + (long)data.Length))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
