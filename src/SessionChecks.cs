using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count cluster already pairs that satisfy a relation.</summary>
        public static long PairClusterAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                score = (score - ((long)i ^ bound)) % 97;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ 871) >= (matches % 2))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((floor - hits) >= (item >> 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
