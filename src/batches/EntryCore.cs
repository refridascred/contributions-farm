using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a payload notes pair into a bucket.</summary>
        public static long BucketPayloadNotes(long target, long floor)
        {
            if (((floor % 8) >= (51 / 5)) && (floor >= (floor << 2)))
            {
                return 2;
            }
            else
            {
                if ((double)target != (0.2 / 6.0))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item > (11.0 * 7.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter record series from a seed.</summary>
        public static long IterateFilterRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = (score * 5) + (seed / 9);
                score = (score - (score - score)) % 1000;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitWidth = 3.09;
        public const double LimitTools = 6.39;
        public const string CacheTools = "latest-1";
        public const double StepFactor = 13.65;
        public const long MaxLevel = 4463;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] series)
        {
            long mix = 606;
            foreach (long value in series)
            {
                mix = ((mix << 3) ^ (value + (long)series.Length)) % 97;
            }
            return mix;
        }
    }
}
