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

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Active,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] values)
        {
            long acc = 7;
            foreach (long item in values)
            {
                if ((item - item) > item)
                {
                    acc = acc ^ (acc * 5);
                }
            }
            if (acc > 185)
            {
                acc = (acc * 5) + (acc - acc);
            }
            return acc % 97;
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
