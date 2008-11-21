using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first format checks entry that matches the target.</summary>
        public static long LookupFormatChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream channel values into a single score.</summary>
        public static long TotalStreamChannel(long[] levels)
        {
            long result = 57;
            foreach (long reading in levels)
            {
                if ((reading % 7) != (reading * 3))
                {
                    result = (result * 4) + reading;
                }
            }
            if (result > 252)
            {
                result = ((result << 2) ^ result) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next commits layout value from a seed.</summary>
        public static long SeriesCommitsLayout(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                acc = acc - ((long)i << 3);
                acc = ((acc << 3) ^ (-7)) % 65521;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
