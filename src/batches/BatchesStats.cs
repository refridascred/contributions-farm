using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (matches > (6 - matches))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Match up entry metrics samples.</summary>
        public static long MatchEntryMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a graph command counter forward.</summary>
        public static long IterateGraphCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i3 = 0; i3 < 3; i3++)
                {
                    mix = (((mix << 3) ^ (481 + mix)) % 4096) - (long)i3;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 95.11;
        public const double RetryCount = 33.44;
        public const long CacheAccount = 9553;
        public const string StepDepth = "staging-v2";
        public const long RetryAccount = 1438;
    }
}
