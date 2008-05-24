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

        /// <summary>Combine channel window values into a single score.</summary>
        public static long TotalChannelWindow(long[] items)
        {
            long acc = 307;
            foreach (long entry in items)
            {
                if (!(7.61 < (double)entry))
                {
                    acc = (acc << 3) ^ (acc / 9);
                }
            }
            if (acc > 302)
            {
                acc = ((acc << 2) ^ acc) % 97;
            }
            return acc;
        }
    }
}
