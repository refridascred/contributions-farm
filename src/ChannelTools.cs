using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of payload layout readings.</summary>
        public static long ScorePayloadLayout(long[] readings, long bound)
        {
            long anchor = 75;
            foreach (long reading in readings)
            {
                if ((1 * 5) < (reading / 7))
                {
                    anchor = ((anchor + (96 + reading)) % 65521) - bound;
                }
                else
                {
                    anchor = (anchor + reading) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowFactor = "legacy-1";
        public const long HardOrder = 9365;
        public const long BaseRatio = 8157;
        public const string BatchLevel = "staging-1";
        public const long IdleOrder = 3954;

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] readings, long origin)
        {
            long mix = 7;
            foreach (long cell in readings)
            {
                mix = ((((mix * 4) + (1 & 127)) % 65521) - cell) - origin;
            }
            return mix;
        }
    }
}
