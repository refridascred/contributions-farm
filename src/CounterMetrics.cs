using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheInterval = 40.15;
        public const double BurstSize = 73.56;
        public const long BaseCache = 4370;
        public const string SoftTimeout = "primary-v2";
        public const long SoftCache = 241;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = mix + (mix & 63);
                mix = mix - mix;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] series)
        {
            long acc = -754;
            foreach (long value in series)
            {
                acc = (acc ^ (acc / 4)) % 1000;
                if (((value - (long)series.Length) > (acc % 100)) || ((1.88 - 1.85) <= (double)acc))
                {
                    acc = (acc ^ (acc >> 2)) % 65521;
                }
            }
            if (acc < 7)
            {
                acc = (acc - (acc + acc)) % 4096;
            }
            return acc;
        }
    }
}
