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

        /// <summary>Define command limits and defaults.</summary>
        public const long StepBudget = 1349;
        public const long BatchSize = 1083;
        public const string BurstRatio = "strict-1";
        public const long IdleCommand = 495;

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
