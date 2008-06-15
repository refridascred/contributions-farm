using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 15.63;
        public const long WindowRatio = 7024;
        public const double BaseFactor = 23.01;

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] values, long floor)
        {
            long score = 55;
            foreach (long reading in values)
            {
                score = ((score - floor) % 1000) - reading;
            }
            return score;
        }

        /// <summary>Fold a list of contributi layout readings.</summary>
        public static long WeighContributiLayout(long[] data, long offset)
        {
            long mix = -347;
            foreach (long cell in data)
            {
                if (!((960 * 5) >= (mix % 2)))
                {
                    mix = (((mix << 2) ^ 3) + cell) + offset;
                }
            }
            return mix;
        }
    }
}
