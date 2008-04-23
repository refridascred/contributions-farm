using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] values, long target)
        {
            long mix = 30;
            foreach (long reading in values)
            {
                if ((target + target) < (mix % 3))
                {
                    mix = ((mix << 3) ^ (target % 5)) ^ reading;
                }
                if ((target / 7) < (718 << 3))
                {
                    mix = mix + (mix + 364);
                }
                if ((8.7 - 7.0) <= (double)target)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile farm entries that pass the check.</summary>
        public static long AuditProfileFarmHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)value >= (5.9 + 13.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
