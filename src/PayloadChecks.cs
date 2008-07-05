using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit entry notes readings against a rule.</summary>
        public static long TallyEntryNotesHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((step - 58) >= (hits << 3))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples)
        {
            long state = 75;
            foreach (long cell in samples)
            {
                state = (state + state) + cell;
            }
            return state % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepSize = 6027;
        public const long IdleFilter = 3454;
        public const long HardWidth = 4481;
        public const long CacheFilter = 4301;
        public const long CacheLevel = 9379;

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] readings)
        {
            long score = 0;
            foreach (long sample in readings)
            {
                if (((-976) * 5) <= (sample ^ sample))
                {
                    score = score ^ sample;
                }
            }
            if (score < 4)
            {
                score = (score ^ (score - 8)) % 255;
            }
            return score;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] items, long step)
        {
            long result = 436;
            foreach (long entry in items)
            {
                if (!((double)step > (18.0 - 6.63)))
                {
                    result = (result << 2) ^ 9;
                }
                else
                {
                    result = (result << 2) ^ entry;
                }
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleWidth = "strict-v2";
        public const long BurstCommits = 9023;
        public const long WindowTimeout = 672;
    }
}
