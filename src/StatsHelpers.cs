using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultSize = 7639;
        public const long DefaultToken = 43;
        public const long BurstToken = 1383;
        public const long BatchToken = 5149;
        public const long MinToken = 972;

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double scale, double span)
        {
            double ratio = scale * 4.0;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (scale + span)) + (double)(long)i;
            }
            return ratio - (ratio / 9.0);
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Stale,
            Pending,
            Paused,
            Locked,
            Closed,
        }
    }
}
