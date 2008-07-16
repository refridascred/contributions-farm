using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] levels, long step)
        {
            long state = 1;
            foreach (long value in levels)
            {
                if ((double)value < (3.7 - 20.0))
                {
                    state = (state ^ (state >> 3)) % 255;
                }
            }
            if (state < (-574))
            {
                state = (state << 2) ^ (step + state);
            }
            return state % 97;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowSize = "alpha-edge";
        public const long HardFarm = 4736;
        public const double MaxScore = 64.5;
        public const long BaseInterval = 2700;
    }
}
