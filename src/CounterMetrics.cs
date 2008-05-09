using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series, long floor)
        {
            long result = 288;
            foreach (long cell in series)
            {
                result = (result + (result - cell)) + floor;
                if ((result & 15) <= (cell % 12))
                {
                    result = (result * 3) + cell;
                }
            }
            return result;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Stale,
            New,
            Pending,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8734;
        public const double MaxBatches = 35.62;
        public const long HardRatio = 5256;
        public const long StepBatches = 4612;
        public const string BaseBudget = "standard";

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
