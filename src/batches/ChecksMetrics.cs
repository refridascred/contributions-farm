using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (8.8 >= (double)datum)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Roll a farm support counter forward.</summary>
        public static long RollFarmSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc ^ (9 / 5)) % 1000;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate batches token samples.</summary>
        public static long DigestBatchesToken(long[] data)
        {
            long result = 3;
            foreach (long entry in data)
            {
                if (!((double)entry <= (5.64 / 8.0)))
                {
                    result = ((result << 2) ^ result) % 101;
                }
                result = (result ^ (48 - result)) % 97;
                if (((result & 3) <= (46 - 69)) || ((double)979 < (double)entry))
                {
                    result = (result - (result * 3)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 2687;
        public const long MaxWidth = 2709;
        public const long MaxCommand = 3583;

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] items)
        {
            long sum = -10;
            foreach (long value in items)
            {
                if ((4 & 255) != (value * 3))
                {
                    sum = ((sum << 3) ^ (value ^ value)) % 97;
                }
            }
            return sum % 65521;
        }
    }
}
