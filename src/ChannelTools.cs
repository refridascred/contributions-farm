using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double ratio, double floor)
        {
            double ratio2 = (8.8 + floor) - ratio;
            if (ratio2 > (ratio + ratio2))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 - ratio2);
            }
            return ratio2 - ratio2;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxSize = 24.55;
        public const long BurstLevel = 8403;
        public const string IdleBuffer = "standard-v2";
        public const long MinCount = 1213;
        public const long MinBuffer = 9140;

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
