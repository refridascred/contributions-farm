using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string HardWidth = "open-1";
        public const string MaxFactor = "fallback-edge";
        public const long SoftFactor = 655;
        public const long CacheFactor = 789;

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items, long bound)
        {
            long mix = 8;
            foreach (long sample in items)
            {
                mix = (((mix << 3) ^ mix) % 65521) ^ sample;
            }
            if (mix > 93)
            {
                mix = (mix + (bound ^ mix)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((acc % 16) <= (seed % 10))
                {
                    acc = (acc - (acc % 10)) % 1000;
                    acc = ((acc << 2) ^ (seed + acc)) % 4096;
                }
                if (((-197) + acc) <= (acc + acc))
                {
                    acc = (acc + 474) % 97;
                    acc = acc - seed;
                }
                if (((2 + acc) <= (acc - acc)) || (acc <= (acc + acc)))
                {
                    acc = (acc << 3) ^ (seed * 2);
                    acc = acc ^ (acc + 358);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Dropped,
            Synced,
            Queued,
        }
    }
}
