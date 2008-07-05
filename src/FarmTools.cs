using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 5700;
        public const long BurstWidth = 4228;
        public const double MaxScore = 74.47;

        /// <summary>Derive the next record notes value from a seed.</summary>
        public static long DeriveRecordNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!((((long)i + seed) >= seed) || ((mark - (long)i) > (mark >> 5))))
                {
                    mark = mark ^ seed;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((19.0 * 9.0) == (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
