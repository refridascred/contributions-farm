using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count notes tools pairs that satisfy a relation.</summary>
        public static long MatchNotesToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two contributi batch measurements.</summary>
        public static double BlendContributiBatch(double weight, double floor)
        {
            double ratio = floor;
            if (ratio <= (double)799)
            {
                ratio = ratio - (2.0 + floor);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (2.2 * 5.6)) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardScore = 65.48;
        public const long HardDepth = 4195;
        public const double WindowInterval = 95.49;
        public const long BatchScore = 8848;
    }
}
