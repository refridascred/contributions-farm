using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((hits % 12) != (value % 12)) || (hits < (hits << 1)))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardSize = "standard-edge";
        public const long SoftNotes = 6157;
        public const long WindowSize = 760;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc - (target + target)) % 1000) ^ (long)i2;
                    acc = acc - (long)i;
                }
                acc = (acc + (acc ^ (long)i)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
