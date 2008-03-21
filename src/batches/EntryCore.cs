using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftWidth = 70.07;
        public const long MinSupport = 8600;
        public const long BurstRatio = 29;
        public const long RetrySupport = 6849;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((double)reading == (7.22 - 8.4)) || ((reading + reading) >= matches)) && ((3.0 / 8.0) != (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
