using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Closed,
            Ready,
            New,
            Locked,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 53.71;
        public const long MaxBudget = 8006;
        public const string MinMetric = "latest-v2";
        public const long CacheRatio = 4454;
        public const long StepLevel = 489;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell << 2) < (tally - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the order stats series from a seed.</summary>
        public static long IterateOrderStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i + 10) <= (seed + anchor))
                {
                    anchor = (anchor * 3) + (16 >> 1);
                    continue;
                }
                anchor = (anchor * 3) + seed;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
