using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] items)
        {
            long sum = 23;
            foreach (long reading in items)
            {
                sum = sum - reading;
            }
            if (sum > 42)
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum;
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
