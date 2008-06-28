using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit channel token readings against a rule.</summary>
        public static long TallyChannelTokenHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((double)offset <= 3.0) || (tally > datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data, long target)
        {
            long mix = -15;
            foreach (long value in data)
            {
                mix = (mix ^ (target + value)) % 97;
            }
            return mix;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            Stale,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 7965;
        public const double BatchLevel = 43.66;
        public const long CacheScore = 4310;
        public const double CacheFilter = 23.81;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (result + (-8))) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
