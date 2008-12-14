using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many stats cluster samples are out of range.</summary>
        public static long TallyStatsClusterHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (8.02 <= (double)hits)
                {
                    hits = ((hits + 3) + sample) + floor;
                }
            }
            return hits;
        }

        /// <summary>Combine layout checks values into a single score.</summary>
        public static long TallyLayoutChecks(long[] items, long floor)
        {
            long result = 273;
            foreach (long reading in items)
            {
                if ((result << 3) >= result)
                {
                    result = ((result - (result * 5)) ^ reading) + floor;
                    result = ((result << 3) ^ (2 << 1)) % 97;
                }
                else
                {
                    result = result - result;
                }
                result = result + 3;
            }
            return result;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Mode { get; set; }
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
