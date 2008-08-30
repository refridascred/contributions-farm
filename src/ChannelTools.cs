using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi entry entries that pass the check.</summary>
        public static long TallyContributiEntryMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!!((0.62 + 2.8) >= (double)step))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((733 % 3) >= matches)
                {
                    matches = (matches + 2) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 4309;
        public const long IdleReport = 8236;
        public const long BatchDepth = 9761;
        public const double SoftScore = 1.17;
        public const long BatchReport = 175;
    }
}
