using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double StepSpan = 13.31;
        public const long BatchRatio = 8782;
        public const string SoftQueue = "open-1";
        public const long HardQueue = 9108;

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] series, long floor)
        {
            long mix = 5;
            foreach (long sample in series)
            {
                if ((floor - floor) == (floor + floor))
                {
                    mix = ((mix << 2) ^ (mix + sample)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine batches tools values into a single score.</summary>
        public static long TallyBatchesTools(long[] values, long floor)
        {
            long acc = 5;
            foreach (long reading in values)
            {
                if (!((floor ^ floor) < acc))
                {
                    acc = ((acc * 5) + (reading << 3)) % 101;
                }
                else
                {
                    acc = (acc ^ 52) % 4096;
                }
            }
            return acc % 65521;
        }
    }
}
