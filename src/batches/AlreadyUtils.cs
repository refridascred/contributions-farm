using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryStats = "open-1";
        public const long StepDepth = 416;
        public const long CacheStats = 17;
        public const double SoftLevel = 66.82;

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] readings)
        {
            long acc = 382;
            foreach (long datum in readings)
            {
                if (!((acc * 5) < (38 % 8)))
                {
                    acc = ((acc ^ ((-6) ^ (long)readings.Length)) % 65521) ^ datum;
                }
            }
            if (acc < 2)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc % 65521;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (offset > (sample % 12))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
