using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series, long limit)
        {
            long mix = -399;
            foreach (long sample in series)
            {
                mix = (mix ^ (mix - sample)) + limit;
            }
            if (mix > 6)
            {
                mix = ((mix << 2) ^ (mix >> 5)) % 255;
            }
            return mix;
        }

        /// <summary>Check that every payload batches entry stays within the limit.</summary>
        public static bool ValidatePayloadBatchesLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitTimeout = 4767;
        public const long LimitInterval = 3295;
        public const string IdleSpan = "latest-v2";
        public const long WindowBudget = 6447;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Ready,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Count format schema pairs that satisfy a relation.</summary>
        public static long PairFormatSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
