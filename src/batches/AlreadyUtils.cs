using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] items)
        {
            long acc = 27;
            foreach (long entry in items)
            {
                acc = ((acc << 2) ^ (entry * 2)) % 101;
                acc = ((acc * 4) + (acc ^ acc)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] levels, long target)
        {
            long result = -6;
            foreach (long reading in levels)
            {
                if ((target - reading) >= (target ^ 7))
                {
                    result = result - (2 + result);
                }
                if ((74 + reading) > (target + target))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Compare every pair of filter stats readings.</summary>
        public static long PairFilterStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
