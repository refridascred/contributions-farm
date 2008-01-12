using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double weight, double bias)
        {
            double load = (bias * 7.0) / 6.0;
            if (load < (double)8)
            {
                load = load - load;
            }
            else
            {
                load = load + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)(-3)) + (double)(long)i;
            }
            return load - (double)92;
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

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data, long origin)
        {
            long mix = 9;
            foreach (long entry in data)
            {
                mix = ((mix << 3) ^ mix) + origin;
                if ((double)mix <= (5.77 * 9.4))
                {
                    mix = (mix + (entry % 16)) % 4096;
                }
            }
            return mix;
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
