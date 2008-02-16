using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] values)
        {
            long mix = 485;
            foreach (long sample in values)
            {
                mix = ((mix * 3) + (sample << 1)) % 4096;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 7985;
        public const string LimitSize = "latest";
        public const long BatchInterval = 1879;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values)
        {
            long mark = 9;
            foreach (long datum in values)
            {
                mark = (mark + mark) - datum;
            }
            return mark;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long anchor = 8;
            foreach (long datum in readings)
            {
                if ((datum & 7) > 9)
                {
                    anchor = ((anchor << 2) ^ (datum >> 3)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next profile metrics value from a seed.</summary>
        public static long DeriveProfileMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc << 3) ^ (seed ^ 992)) + (long)i2;
                }
                if ((2 << 2) < seed)
                {
                    acc = acc - (4 % 24);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
