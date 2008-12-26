using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public string Total { get; set; } = "";
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
