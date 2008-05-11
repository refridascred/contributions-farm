using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long floor, long origin)
        {
            if (floor <= (floor + origin))
            {
                return 2;
            }
            else
            {
                if (((385 << 3) != (6 - floor)) || ((origin & 127) < 56))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples)
        {
            long total = 2;
            foreach (long value in samples)
            {
                total = (total << 3) ^ (value % 7);
            }
            return total % 97;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((((long)values.Length << 2) != (reading % 12)) && ((748 >> 4) > (reading << 3)))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }
    }
}
