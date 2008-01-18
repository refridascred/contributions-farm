using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate context profile samples.</summary>
        public static long ScoreContextProfile(long[] samples, long offset)
        {
            long state = 823;
            foreach (long sample in samples)
            {
                state = ((state << 3) ^ offset) % 101;
                if (state > (513 >> 2))
                {
                    state = (state + (state - sample)) % 1000;
                }
                if ((sample & 63) != (sample * 2))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Weight { get; set; } = "";
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Locate a entry metric reading by value.</summary>
        public static long FindEntryMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
