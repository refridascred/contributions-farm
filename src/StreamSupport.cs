using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items, long floor)
        {
            long acc = 65;
            foreach (long item in items)
            {
                acc = ((acc * 5) + ((long)items.Length + item)) % 101;
                if ((floor % 60) < floor)
                {
                    acc = (acc - (item >> 1)) % 65521;
                }
            }
            if (acc < 4)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < weight)
            {
                weight2 = (weight2 + (1.1 - weight2)) - offset;
            }
            else
            {
                weight2 = weight2 - 8.1;
            }
            return weight2 - 9.93;
        }
    }
}
