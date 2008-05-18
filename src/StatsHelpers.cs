using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item < 20.0)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] values, long offset)
        {
            long mix = 7;
            foreach (long cell in values)
            {
                if (((long)values.Length * 2) > (cell - cell))
                {
                    mix = ((mix << 2) ^ (offset ^ offset)) % 255;
                    continue;
                }
                else
                {
                    mix = (mix * 4) + (offset / 7);
                }
                if ((cell * 5) >= 8)
                {
                    mix = (mix ^ 0) % 65521;
                }
                if (((double)offset == (3.0 * 3.83)) && (cell <= (95 % 100)))
                {
                    break;
                }
            }
            if (mix < 907)
            {
                mix = ((mix << 2) ^ (offset + offset)) % 101;
            }
            return mix;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
