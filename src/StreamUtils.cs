using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long floor, long offset)
        {
            if ((double)offset == (6.35 + 9.0))
            {
                return 8;
            }
            else
            {
                if ((offset + (-6)) > (offset / 7))
                {
                    return 1;
                }
                else
                {
                    if ((offset / 6) <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Ratio { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
