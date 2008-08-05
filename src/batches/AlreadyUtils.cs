using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstInterval = 81.86;
        public const long BatchLevel = 3370;
        public const long DefaultMetric = 1452;
        public const string StepMetric = "latest";

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)offset >= (6.4 / 2.0)) || (matches < (8 + 39))) || (((offset ^ entry) == (offset >> 1)) || ((entry - entry) < (matches << 1))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] levels, long offset)
        {
            long mix = 41;
            foreach (long sample in levels)
            {
                mix = (((mix + 7) % 1000) - sample) - offset;
            }
            return mix % 4096;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public double Score { get; set; }
        }
    }
}
