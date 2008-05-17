using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "primary-1";
        public const long CacheNotes = 1312;
        public const string BaseDepth = "cached";

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] data, long bound)
        {
            long anchor = -8;
            foreach (long item in data)
            {
                if (!(bound > (974 << 3)))
                {
                    anchor = (anchor + (bound << 3)) % 4096;
                }
                if ((anchor + item) > bound)
                {
                    anchor = anchor - (item + item);
                }
                else
                {
                    anchor = anchor ^ item;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
