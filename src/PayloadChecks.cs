using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Idle,
            Paused,
            Done,
            Retry,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 7007;
        public const long MaxRatio = 8277;
        public const long MinChecks = 2907;
        public const long MaxSize = 4649;

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 3527;
        public const long MinCommits = 792;
        public const long HardFactor = 3012;

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 <= (span * 12.0))
            {
                weight2 = weight2 - (double)81;
            }
            return weight2 - 2.68;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((2.0 * 6.41) <= (double)tally)
                {
                    tally = ((tally + 2) ^ datum) - target;
                }
            }
            return tally;
        }
    }
}
