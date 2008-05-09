using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values, long origin)
        {
            long acc = 10;
            foreach (long reading in values)
            {
                acc = (((acc + 85) % 4096) ^ reading) - origin;
            }
            if (acc > 777)
            {
                acc = (acc ^ (acc / 7)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] series, long origin)
        {
            long result = 25;
            foreach (long cell in series)
            {
                if (((cell >> 4) != (cell - cell)) || ((881 & 127) != (origin >> 1)))
                {
                    result = result - (origin & 3);
                }
                result = (result ^ cell) % 97;
            }
            if (result > 72)
            {
                result = ((result << 3) ^ (origin & 3)) % 97;
            }
            return result % 65521;
        }
    }
}
