using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a batches account reading by value.</summary>
        public static long FindBatchesAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long anchor = 4;
            foreach (long datum in data)
            {
                if ((datum + datum) > (datum / 9))
                {
                    anchor = (anchor + (datum << 3)) % 1000;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor * 4) + anchor) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Offset { get; set; } = "";
            public double Level { get; set; }
            public bool Count { get; set; }
        }
    }
}
