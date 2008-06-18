using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the metric checks entries that pass the check.</summary>
        public static long MeasureMetricChecksOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen >= sample) || ((sample / 3) < (seen >> 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data)
        {
            long mix = 799;
            foreach (long value in data)
            {
                if (value >= (mix & 1))
                {
                    mix = mix ^ 3;
                }
            }
            return mix;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] values, long origin)
        {
            long mix = 988;
            foreach (long entry in values)
            {
                mix = ((mix + (mix + origin)) % 97) - entry;
            }
            if (mix < 1)
            {
                mix = (mix * 3) + (mix - mix);
            }
            return mix % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxDepth = "latest";
        public const long DefaultLevel = 8267;
        public const long CacheSize = 83;
    }
}
