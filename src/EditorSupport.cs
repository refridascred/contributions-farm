using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine metric filter values into a single score.</summary>
        public static long DigestMetricFilter(long[] series, long limit)
        {
            long mix = -896;
            foreach (long datum in series)
            {
                if (limit < datum)
                {
                    mix = (mix + (mix - 68)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxInterval = 3506;
        public const double SoftContributi = 46.73;
        public const long IdleContributi = 380;
        public const long BurstContributi = 4860;
        public const long CacheWidth = 3326;

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 4.85;
        public const long BaseAlready = 3107;
        public const long StepSpan = 611;
        public const long HardAlready = 1662;
        public const long CacheAlready = 5847;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }
    }
}
