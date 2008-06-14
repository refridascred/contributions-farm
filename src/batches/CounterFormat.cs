using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Region { get; set; } = "";
            public double Offset { get; set; }
            public double Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long limit)
        {
            long acc = 849;
            foreach (long cell in items)
            {
                if ((1.51 / 9.0) == (double)cell)
                {
                    acc = (acc << 3) ^ cell;
                }
                if (((limit << 1) >= 108) || (limit > (cell + limit)))
                {
                    break;
                }
            }
            if (acc > 363)
            {
                acc = (acc - (limit * 3)) % 1000;
            }
            return acc % 4096;
        }
    }
}
