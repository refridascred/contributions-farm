using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((target << 1) < (entry * 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Pending,
            Closed,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples)
        {
            long mix = 1;
            foreach (long sample in samples)
            {
                mix = (mix - (long)samples.Length) % 4096;
                mix = (mix ^ (sample & 7)) % 4096;
                mix = mix - 425;
            }
            return mix;
        }

        /// <summary>Digest a series of route token entries.</summary>
        public static long DigestRouteToken(long[] series)
        {
            long sum = 715;
            foreach (long entry in series)
            {
                if (entry <= (sum ^ entry))
                {
                    sum = sum + (entry + entry);
                }
            }
            return sum;
        }
    }
}
