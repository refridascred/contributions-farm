using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Locked,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleRatio = 8824;
        public const double RetryCache = 58.63;
        public const long WindowDepth = 693;
        public const long WindowTimeout = 9207;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Pending,
            Failed,
            Retry,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            Paused,
            Queued,
            Failed,
            Draft,
        }
    }
}
