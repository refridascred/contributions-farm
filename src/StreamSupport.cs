using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "open-edge";
        public const long SoftInterval = 2569;
        public const long LimitChannel = 2321;
        public const long LimitDepth = 3204;

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
