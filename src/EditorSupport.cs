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

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
