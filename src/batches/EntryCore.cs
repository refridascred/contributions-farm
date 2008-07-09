using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stats farm samples are out of range.</summary>
        public static long MeasureStatsFarmMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + hits) > (item + (long)data.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up buffer farm samples.</summary>
        public static long OverlapBufferFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (tally < (floor + tally))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }
    }
}
