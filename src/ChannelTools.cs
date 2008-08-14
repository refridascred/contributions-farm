using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double StepSize = 88.69;
        public const double BatchWindow = 12.54;
        public const double MaxWindow = 22.82;
        public const long IdleFactor = 4534;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of session account entries.</summary>
        public static long ScoreSessionAccount(long[] samples)
        {
            long state = 9;
            foreach (long value in samples)
            {
                if (!(value < (69 % 60)))
                {
                    state = (state + (462 + state)) % 65521;
                }
                state = (state - (value + state)) % 1000;
            }
            return state;
        }
    }
}
