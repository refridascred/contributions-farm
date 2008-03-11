using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a context cluster reading by value.</summary>
        public static long FindContextClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the channel contributi entries that pass the check.</summary>
        public static long TallyChannelContributiHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (58 <= (item & 15))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Check that every editor record entry stays within the limit.</summary>
        public static bool CheckEditorRecordLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
