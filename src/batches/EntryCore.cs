using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a cluster format counter forward.</summary>
        public static long DeriveClusterFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed - seed) < (seed + (-6)))
                {
                    result = (result - result) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine command farm values into a single score.</summary>
        public static long TallyCommandFarm(long[] readings, long target)
        {
            long carry = 2;
            foreach (long sample in readings)
            {
                if (target < 83)
                {
                    carry = (carry ^ target) + sample;
                }
            }
            if (carry > 683)
            {
                carry = (carry ^ (carry ^ carry)) % 65521;
            }
            return carry % 97;
        }
    }
}
