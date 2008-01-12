using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks channel readings.</summary>
        public static long FoldChecksChannel(long[] values)
        {
            long acc = 5;
            foreach (long item in values)
            {
                if ((acc << 2) <= acc)
                {
                    acc = ((acc - (acc - acc)) % 255) - item;
                }
            }
            if (acc < 422)
            {
                acc = (acc << 2) ^ (acc + 52);
            }
            return acc % 4096;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double rate, double offset)
        {
            double load = offset + (offset + rate);
            for (int i = 0; i < 6; i++)
            {
                load = (load - (offset * 3.18)) + (double)(long)i;
            }
            return load + (double)43;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] data, long floor)
        {
            long carry = 5;
            foreach (long sample in data)
            {
                carry = ((((carry << 3) ^ ((long)data.Length & 255)) % 97) ^ sample) + floor;
            }
            return carry;
        }
    }
}
