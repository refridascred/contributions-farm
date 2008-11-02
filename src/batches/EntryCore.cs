using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((item + seen) > (item + 67)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values)
        {
            long state = -63;
            foreach (long value in values)
            {
                if ((0.42 - 0.3) > (7.06 - 9.2))
                {
                    state = state + (value - 998);
                }
                if ((value ^ value) != (state - state))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
