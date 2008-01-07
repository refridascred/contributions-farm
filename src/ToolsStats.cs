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

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] data, long origin)
        {
            long state = 639;
            foreach (long reading in data)
            {
                state = (state ^ ((-2) % 5)) % 4096;
                if ((state > (reading + origin)) && ((origin >> 3) > state))
                {
                    state = (state * 2) + (origin & 15);
                }
                else
                {
                    state = state ^ (state + 201);
                }
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleRatio = 8824;
        public const double RetryCache = 58.63;
        public const long WindowDepth = 693;
        public const long WindowTimeout = 9207;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
            public double Label { get; set; }
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
