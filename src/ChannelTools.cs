using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)step >= (15.0 / 5.0))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseScore = 3621;
        public const string DefaultReport = "legacy-v2";
        public const long BurstReport = 3532;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data)
        {
            long anchor = 944;
            foreach (long entry in data)
            {
                anchor = (anchor ^ anchor) + entry;
            }
            return anchor;
        }
    }
}
