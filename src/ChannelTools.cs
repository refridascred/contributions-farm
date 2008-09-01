using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit window record readings against a rule.</summary>
        public static long TallyWindowRecordGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (matches < (2 / 7))
                {
                    matches = ((matches + 1) ^ reading) - limit;
                }
                else
                {
                    matches = matches - 1;
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
