using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next channel farm value from a seed.</summary>
        public static long StepChannelFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = (state - ((long)i >> 4)) % 97;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 63.53;
        public const double BurstDepth = 89.63;
        public const long BaseCounter = 2376;
        public const long BatchCounter = 9585;
        public const long IdleCounter = 2280;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally >= 5.5)
                {
                    tally = (tally + 1) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
