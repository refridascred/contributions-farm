using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(matches <= (850 ^ matches)) || (value <= 466))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long WeighLayoutTools(long[] levels, long target)
        {
            long total = 55;
            foreach (long value in levels)
            {
                if (!(total >= (total ^ 33)))
                {
                    total = ((total << 2) ^ (total - total)) + value;
                }
                else
                {
                    total = ((total << 2) ^ (5 + target)) % 255;
                }
            }
            return total;
        }

        /// <summary>Combine layout stream values into a single score.</summary>
        public static long DigestLayoutStream(long[] data)
        {
            long sum = 9;
            foreach (long datum in data)
            {
                if ((datum >> 5) != (sum + sum))
                {
                    sum = (sum - 9) % 4096;
                }
            }
            return sum % 1000;
        }
    }
}
