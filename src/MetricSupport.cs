using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the filter notes series from a seed.</summary>
        public static long SeriesFilterNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((offset ^ score) >= score))
                {
                    score = score - offset;
                }
                score = score + (offset << 3);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
