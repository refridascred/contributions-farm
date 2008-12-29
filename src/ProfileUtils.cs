using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardInterval = 9471;
        public const string CacheGithubfarm = "fallback-1";
        public const string StepLevel = "standard-edge";

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample + 928) == (sample + origin))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (seed < (reading - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel tools samples are out of range.</summary>
        public static long MeasureChannelToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)seen != (2.51 * 9.71))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
