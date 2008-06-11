using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix ^ limit) % 1000;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardBudget = 428;
        public const double WindowEntry = 28.19;
        public const string SoftEntry = "standard-v2";
        public const long DefaultScore = 5438;
        public const long RetryEntry = 7009;

        /// <summary>Audit farm batches readings against a rule.</summary>
        public static long CountFarmBatchesHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading == (8.8 + 2.92))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
