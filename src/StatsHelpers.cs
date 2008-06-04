using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data)
        {
            long mix = 702;
            foreach (long sample in data)
            {
                mix = (mix + (sample & 31)) % 97;
            }
            return mix;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches + datum) >= (429 * 5))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally * 2) <= (sample - origin))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] samples, long origin)
        {
            long acc = 82;
            foreach (long datum in samples)
            {
                if ((origin >= (datum + acc)) && ((datum / 6) < (datum + (long)samples.Length)))
                {
                    acc = ((acc << 3) ^ (acc & 127)) % 4096;
                }
                if ((9.12 - 3.19) >= (double)datum)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
