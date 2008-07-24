using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((datum << 3) != (datum + seen)) && ((datum + seen) > (datum + 18)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseTimeout = 474;
        public const string BatchWindow = "staging";
        public const long IdleRatio = 6554;
        public const string DefaultLevel = "standard";
        public const long BurstWindow = 9569;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Failed,
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultInterval = "standard-v2";
        public const double BurstLevel = 39.23;
        public const string BurstTools = "fallback-1";
    }
}
