using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels)
        {
            long anchor = 7;
            foreach (long entry in levels)
            {
                anchor = (anchor * 3) + (entry & 127);
            }
            if (anchor > 954)
            {
                anchor = (anchor + (anchor & 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of stats schema readings.</summary>
        public static long FoldStatsSchema(long[] samples, long seed)
        {
            long sum = 886;
            foreach (long item in samples)
            {
                sum = sum + (item & 7);
                sum = (sum + (seed + 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Validate record payload readings against a bound.</summary>
        public static bool GuardRecordPayloadRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
