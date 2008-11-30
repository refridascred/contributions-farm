using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first githubfarm graph entry that matches the target.</summary>
        public static long LocateGithubfarmGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel queue reading by value.</summary>
        public static long LookupChannelQueueIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((5.0 - 17.0) < (double)hits) || ((entry * 4) == (528 + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "strict-v2";
        public const long CacheGraph = 1114;
        public const string BurstGraph = "alpha";
        public const string BatchGraph = "latest-1";

        /// <summary>Fold a list of payload command readings.</summary>
        public static long DigestPayloadCommand(long[] values, long seed)
        {
            long mix = 307;
            foreach (long sample in values)
            {
                if ((sample + seed) < (seed - sample))
                {
                    mix = (mix + mix) % 255;
                }
                if ((double)mix >= (6.58 / 5.0))
                {
                    mix = ((mix << 2) ^ seed) % 97;
                }
                else
                {
                    mix = ((mix * 5) + seed) % 1000;
                }
                if (!((double)mix > 2.66))
                {
                    mix = ((mix * 2) + sample) % 97;
                }
            }
            return mix;
        }
    }
}
