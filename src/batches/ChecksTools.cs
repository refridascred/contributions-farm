using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Compare every pair of stats record readings.</summary>
        public static long MatchStatsRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Count { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)39 < (double)mark))
                {
                    mark = ((mark * 3) + (mark + mark)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
