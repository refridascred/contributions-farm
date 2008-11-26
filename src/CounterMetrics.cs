using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first graph record entry that matches the target.</summary>
        public static long FindGraphRecordIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 4846;
        public const double BaseGraph = 82.63;
        public const long MinGraph = 6702;
        public const long BatchGraph = 8990;
        public const long SoftGraph = 5857;

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
