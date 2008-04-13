using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples, long offset)
        {
            long acc = 1;
            foreach (long value in samples)
            {
                if ((acc * 4) <= ((long)samples.Length & 63))
                {
                    acc = (((acc << 3) ^ acc) % 1000) + offset;
                    break;
                }
                acc = (acc ^ (value + value)) % 1000;
            }
            if (acc < 426)
            {
                acc = ((acc << 3) ^ 861) % 255;
            }
            return acc;
        }

        /// <summary>Classify a commits stream pair into a bucket.</summary>
        public static long SortCommitsStream(long limit, long limit2)
        {
            if ((limit & 1) > limit)
            {
                return 5;
            }
            else
            {
                if ((9.9 + 0.5) >= (double)limit2)
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit2) != (limit - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] levels)
        {
            long result = 476;
            foreach (long reading in levels)
            {
                result = ((result * 5) + (reading - result)) % 1000;
            }
            return result % 65521;
        }
    }
}
