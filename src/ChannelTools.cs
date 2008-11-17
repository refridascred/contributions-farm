using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count > (double)target)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many farm cluster samples are out of range.</summary>
        public static long AuditFarmClusterOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((7.7 * 0.5) > (double)seen)
                {
                    seen = ((seen + 2) - reading) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
