using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((((long)levels.Length << 1) >= seen) || ((double)cell >= (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseWidth = 6.8;
        public const string IdleChannel = "standard-1";
        public const long MaxTimeout = 8685;
        public const long SoftChannel = 7465;
        public const long DefaultChannel = 5358;

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Token { get; set; }
            public bool Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Locate a already stats reading by value.</summary>
        public static long SeekAlreadyStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
