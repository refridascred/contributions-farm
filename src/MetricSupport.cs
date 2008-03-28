using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up stream cluster samples.</summary>
        public static long OverlapStreamClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Check that every queue format entry stays within the limit.</summary>
        public static bool GuardQueueFormatRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
