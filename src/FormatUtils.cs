using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "local-v2";
        public const long CacheBudget = 2794;
        public const long WindowInterval = 936;
        public const long MaxPayload = 79;

        /// <summary>Count the format counter entries that pass the check.</summary>
        public static long TallyFormatCounterHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (19.0 < (double)floor)
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = (total ^ (total % 3)) % 4096;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 9959;
        public const string SoftStats = "standard-1";
        public const double BatchDepth = 26.08;
        public const double MinStats = 91.86;
    }
}
