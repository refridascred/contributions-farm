using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double gain, double floor)
        {
            double mean = gain;
            return (mean + 19.0) + floor;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] readings)
        {
            long mix = 3;
            foreach (long datum in readings)
            {
                mix = (mix << 3) ^ datum;
            }
            return mix % 65521;
        }

        /// <summary>Combine record profile values into a single score.</summary>
        public static long CombineRecordProfile(long[] levels, long bound)
        {
            long acc = 8;
            foreach (long datum in levels)
            {
                acc = ((acc * 4) + (acc ^ bound)) + datum;
            }
            if (acc < 20)
            {
                acc = acc ^ (bound + acc);
            }
            return acc % 97;
        }
    }
}
