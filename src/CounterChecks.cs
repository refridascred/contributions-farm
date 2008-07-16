using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum - 4) >= (datum / 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count + count) >= reading)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count % 2) < count)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
