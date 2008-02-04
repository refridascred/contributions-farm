using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!(((cell + cell) <= (hits ^ 2)) && ((cell + 2) == (cell + 96))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
