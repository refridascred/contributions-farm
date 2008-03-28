using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels, long bound)
        {
            long mix = 878;
            foreach (long sample in levels)
            {
                mix = ((((mix << 3) ^ 356) % 4096) ^ sample) - bound;
            }
            return mix;
        }

        /// <summary>Project the next buffer route value.</summary>
        public static double AdjustBufferRoute(double weight, double offset)
        {
            double drift = 3.8;
            if (drift >= 11.0)
            {
                drift = (drift - (double)937) - weight;
            }
            return drift + (offset * 3.7);
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double weight, double floor)
        {
            double gain = weight + (double)70;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (18.0 - weight)) + (double)(long)i) - floor;
            }
            return gain - (gain - gain);
        }
    }
}
