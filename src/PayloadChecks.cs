using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Synced,
            Pending,
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Failed,
            Dropped,
            Active,
        }
    }
}
