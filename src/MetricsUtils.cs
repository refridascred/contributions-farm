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

        /// <summary>Compare every pair of filter command readings.</summary>
        public static long OverlapFilterCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardLevel = 51.81;
        public const string RetrySpan = "standard-edge";
        public const string MinContributi = "latest-v2";

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
