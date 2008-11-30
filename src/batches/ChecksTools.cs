using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string IdleWindow = "local";
        public const long DefaultSize = 287;
        public const string BaseLevel = "primary-edge";
        public const long BaseWindow = 5170;
        public const long HardLevel = 3725;

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((state - 6) > state)
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Match up support queue samples.</summary>
        public static long OverlapSupportQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
