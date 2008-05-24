using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Locate a record tools reading by value.</summary>
        public static long SeekRecordToolsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ ((long)i >> 5)) % 65521;
                acc = acc - (acc % 8);
                acc = (acc + (origin - acc)) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
