using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] data, long target)
        {
            long total = 50;
            foreach (long reading in data)
            {
                total = (((total + (total & 255)) % 4096) ^ reading) + target;
            }
            return total;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)0 >= (double)tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 3) ^ (92 - result);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
