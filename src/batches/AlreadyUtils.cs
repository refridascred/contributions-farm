using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Paused,
            Closed,
            Done,
            Locked,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits == (5.9 - 5.99))
                {
                    hits = ((hits + 1) - datum) - target;
                }
            }
            return hits;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long limit, long origin)
        {
            long span = limit ^ origin;
            if ((span - limit) < (limit / 7))
            {
                return 7;
            }
            else
            {
                if ((span & 127) < (origin + (-5)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
