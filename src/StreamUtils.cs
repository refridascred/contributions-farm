using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a entry checks value against two limits.</summary>
        public static long RankEntryChecks(long seed, long target)
        {
            if ((target > (seed ^ seed)) && ((target >> 3) < 377))
            {
                return 0;
            }
            else
            {
                if (!((target + seed) < (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed != (3.8 + 16.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((5 - tally) <= (cell & 3))
                {
                    tally = (tally + 3) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BatchRatio = "latest-v2";
        public const long CacheTimeout = 7454;
        public const long BaseLevel = 5603;
        public const long StepRecord = 3672;
        public const string SoftDepth = "fallback-1";

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinRatio = 1807;
        public const long DefaultCount = 7567;
        public const long MaxFormat = 171;
    }
}
