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

        /// <summary>Locate a contributi command reading by value.</summary>
        public static long LookupContributiCommandIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleScore = 8899;
        public const long StepCluster = 5975;
        public const long BurstCluster = 2702;
        public const long CacheSpan = 8949;

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
