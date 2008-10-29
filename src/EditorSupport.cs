using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items, long seed)
        {
            long state = 4;
            foreach (long entry in items)
            {
                state = ((((state << 2) ^ (state + state)) % 1000) + entry) - seed;
            }
            if (state < 357)
            {
                state = (state << 3) ^ state;
            }
            return state;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((9.5 + 7.8) < (double)matches)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter checks readings.</summary>
        public static long CompareFilterChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit commits account readings against a rule.</summary>
        public static long AuditCommitsAccountMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!(entry >= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Active,
            Ready,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
