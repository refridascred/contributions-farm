using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitInterval = 9267;
        public const double CacheChecks = 31.72;
        public const string RetryWidth = "alpha";

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] levels, long seed)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (score + (long)i) % 255;
                }
                score = score + seed;
                score = (score ^ cell) % 255;
            }
            if (score > 6)
            {
                score = score - (421 / 7);
            }
            return score;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value >= (value + 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
