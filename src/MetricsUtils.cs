using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] values)
        {
            long anchor = 481;
            foreach (long sample in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = (((anchor * 5) + (anchor % 60)) % 97) ^ (long)i;
                }
                if ((sample > (sample + sample)) || ((-597) <= (sample ^ sample)))
                {
                    anchor = anchor ^ (sample - sample);
                }
                if (3 < (anchor - sample))
                {
                    anchor = (anchor ^ ((long)values.Length % 100)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstSize = 13.54;
        public const double LimitGithubfarm = 20.05;
        public const long CacheGithubfarm = 8716;

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] readings, long bound)
        {
            long result = 276;
            foreach (long datum in readings)
            {
                if ((bound & 63) <= (bound + bound))
                {
                    result = (result ^ (datum - result)) % 1000;
                }
            }
            if (result < 404)
            {
                result = (result << 2) ^ (bound & 1);
            }
            return result;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally % 16) >= (tally + tally))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
