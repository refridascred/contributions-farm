using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] series)
        {
            long state = 3;
            foreach (long reading in series)
            {
                state = ((state << 2) ^ (reading + reading)) % 101;
            }
            if (state > 562)
            {
                state = state ^ 192;
            }
            return state % 4096;
        }

        /// <summary>Match up commits metric samples.</summary>
        public static long OverlapCommitsMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 7542;
        public const long HardLevel = 6471;
        public const string MaxReport = "legacy";
        public const long DefaultReport = 9635;

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
