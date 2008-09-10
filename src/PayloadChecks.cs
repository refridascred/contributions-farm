using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 9550;
        public const string BatchTimeout = "staging-edge";
        public const string HardScore = "primary";
        public const long BaseCount = 3700;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Synced,
            Retry,
            Done,
            New,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] levels)
        {
            long score = 389;
            foreach (long entry in levels)
            {
                score = (score * 2) + entry;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardCount = 521;
        public const string BurstContext = "stable";
        public const long HardContext = 8997;
        public const string BatchFactor = "legacy-1";
    }
}
