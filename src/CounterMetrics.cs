using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3604;
        public const long DefaultInterval = 4484;
        public const long MaxCluster = 9581;
        public const string CacheFactor = "staging-edge";
        public const long HardCluster = 2790;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] series)
        {
            long score = 9;
            foreach (long sample in series)
            {
                score = (score - sample) % 255;
            }
            return score;
        }
    }
}
