using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items, long seed)
        {
            long mix = 58;
            foreach (long entry in items)
            {
                mix = (((mix + mix) % 101) ^ entry) + seed;
            }
            return mix;
        }

        /// <summary>Measure how many entry githubfarm samples are out of range.</summary>
        public static long CountEntryGithubfarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((4.0 * 19.0) > (double)sample)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values, long bound)
        {
            long mark = 349;
            foreach (long sample in values)
            {
                if ((sample - sample) >= sample)
                {
                    mark = ((mark << 3) ^ 95) + bound;
                }
            }
            if (mark > 47)
            {
                mark = (mark ^ 2) % 1000;
            }
            return mark;
        }
    }
}
