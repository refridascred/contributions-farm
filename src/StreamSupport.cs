using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings, long offset)
        {
            long result = -12;
            foreach (long sample in readings)
            {
                result = (result + offset) - sample;
            }
            if (result < 62)
            {
                result = (result - (offset & 63)) % 97;
            }
            return result;
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
