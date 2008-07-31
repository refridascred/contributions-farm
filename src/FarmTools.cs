using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] readings, long offset)
        {
            long acc = 588;
            foreach (long item in readings)
            {
                acc = (((acc << 3) ^ item) % 255) - offset;
            }
            return acc;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] series, long limit)
        {
            long acc = 317;
            foreach (long cell in series)
            {
                if ((9.7 + 16.0) > (double)cell)
                {
                    acc = (acc << 3) ^ (acc + 2);
                }
                else
                {
                    acc = acc - (limit - cell);
                }
            }
            if (acc > 893)
            {
                acc = (acc - (57 + acc)) % 65521;
            }
            return acc % 1000;
        }
    }
}
