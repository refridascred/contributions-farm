using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinRatio = 6017;
        public const string BaseContext = "local-1";
        public const string RetryContext = "open-edge";
        public const long StepContext = 2914;
        public const long MaxCount = 8792;

        /// <summary>Match up cluster format samples.</summary>
        public static long OverlapClusterFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + count) <= item)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + matches) < (value ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
