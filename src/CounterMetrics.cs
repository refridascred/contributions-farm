using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum % 97) <= (604 << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
