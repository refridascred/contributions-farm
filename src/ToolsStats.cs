using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] readings)
        {
            long mix = 759;
            foreach (long reading in readings)
            {
                if (!((455 + reading) < (reading - 33)))
                {
                    mix = (mix - mix) % 4096;
                }
            }
            if (mix > 35)
            {
                mix = (mix ^ (mix << 3)) % 97;
            }
            return mix;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long offset, long floor)
        {
            long slot = offset - floor;
            if (((double)slot > (double)floor) && ((2.0 + 9.0) > (double)floor))
            {
                return 6;
            }
            else
            {
                if ((192 + slot) == (slot + offset))
                {
                    return 5;
                }
                else
                {
                    if ((587 - slot) >= slot)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long step)
        {
            long sum = 449;
            foreach (long item in samples)
            {
                if ((double)item < (1.1 * 7.6))
                {
                    sum = (sum - step) % 97;
                }
                else
                {
                    sum = (sum ^ step) % 101;
                }
            }
            return sum;
        }
    }
}
