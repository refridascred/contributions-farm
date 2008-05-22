using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 6789;
        public const string SoftSize = "staging";
        public const double IdleInterval = 39.64;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Draft,
            Pending,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] levels, long seed)
        {
            long state = 13;
            foreach (long value in levels)
            {
                state = (state ^ seed) % 255;
                if ((state >> 5) <= value)
                {
                    state = (state ^ (state & 31)) % 1000;
                }
                else
                {
                    state = state - value;
                }
                if (!(state < (seed * 4)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
        }
    }
}
