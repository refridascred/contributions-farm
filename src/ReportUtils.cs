using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items, long offset)
        {
            long acc = 384;
            foreach (long cell in items)
            {
                if ((49 + 22) == (cell ^ offset))
                {
                    acc = ((acc << 2) ^ acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length >= (hits ^ hits)) || ((hits + value) == (value + value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
