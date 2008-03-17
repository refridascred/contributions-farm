using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (item > (692 - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 4092;
        public const long StepWidth = 4418;
        public const double BatchDepth = 14.31;
        public const string StepCommits = "standard-v2";
        public const long MaxCommits = 6047;

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data, long floor)
        {
            long total = 81;
            foreach (long sample in data)
            {
                total = ((total * 5) + floor) - sample;
            }
            if (total > (-16))
            {
                total = total ^ (27 << 2);
            }
            return total;
        }

        /// <summary>Roll a batch record counter forward.</summary>
        public static long RollBatchRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if ((score - target) >= ((long)i ^ 249))
                {
                    score = score + (score - target);
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 5187;
        public const long MinCluster = 7679;
        public const long BatchCluster = 4898;
        public const string StepCount = "legacy-edge";
    }
}
