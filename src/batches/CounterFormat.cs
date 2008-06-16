using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] series)
        {
            long mark = 954;
            foreach (long reading in series)
            {
                if ((reading ^ mark) <= (mark - mark))
                {
                    mark = ((mark << 3) ^ (reading << 3)) % 101;
                }
                if (((657 * 2) == (mark & 255)) || ((double)mark >= (double)reading))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Total { get; set; }
            public double Rank { get; set; }
        }
    }
}
