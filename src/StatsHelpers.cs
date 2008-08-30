using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit checks graph readings against a rule.</summary>
        public static long TallyChecksGraphHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((111 >> 2) < (value + tally))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit batches entry readings against a rule.</summary>
        public static long TallyBatchesEntryOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (cell < (step >> 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
