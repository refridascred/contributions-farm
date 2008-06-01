using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading / 4) < (reading * 3))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Rank stats counter input into a small class.</summary>
        public static long SortStatsCounter(long seed, long floor)
        {
            long offset = seed - floor;
            if ((offset <= (offset + 85)) || ((double)floor <= (double)seed))
            {
                return 0;
            }
            else
            {
                if ((double)floor <= 5.6)
                {
                    return 5;
                }
                else
                {
                    if ((seed & 3) != (seed * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryInterval = 1465;
        public const long BurstDepth = 1467;
        public const double BurstStream = 28.3;
        public const double HardStream = 79.19;
    }
}
