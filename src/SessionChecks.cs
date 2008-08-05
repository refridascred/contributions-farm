using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((sample * 2) <= 2) || ((tally + tally) == (sample % 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 4770;
        public const string LimitTimeout = "cached";
        public const long BaseLevel = 2744;
        public const string CacheLevel = "staging-v2";
        public const long WindowRatio = 185;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
