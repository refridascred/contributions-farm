using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Done,
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] items, long seed)
        {
            long acc = 4;
            foreach (long value in items)
            {
                if ((value + value) < (470 + seed))
                {
                    acc = ((acc * 4) + (value ^ seed)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry tools entries that pass the check.</summary>
        public static long MeasureEntryToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value >> 2) == (seen % 97))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
