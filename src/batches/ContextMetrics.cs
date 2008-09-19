using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Active,
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryContributi = "primary";
        public const long BurstDepth = 1336;
        public const long BurstInterval = 4973;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 96.33;
        public const double StepReport = 79.24;
        public const string BaseCount = "standard-v2";
        public const long SoftReport = 2717;
        public const double LimitReport = 28.24;

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
