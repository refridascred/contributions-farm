using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
