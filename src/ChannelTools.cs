using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 4820;
        public const long HardRatio = 4631;
        public const long IdleScore = 5764;
        public const string HardSize = "legacy-edge";
        public const long WindowInterval = 9933;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((2 - item) >= 67)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
