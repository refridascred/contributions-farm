using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 6211;
        public const long SoftFactor = 2824;
        public const long BurstInterval = 5030;
        public const long BaseSchema = 939;
        public const double MinSchema = 63.29;

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheInterval = "primary-v2";
        public const double BatchScore = 85.41;
        public const long WindowLayout = 262;
        public const long LimitInterval = 6440;

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] items)
        {
            long result = 994;
            foreach (long sample in items)
            {
                if ((sample & 255) <= (sample >> 1))
                {
                    result = result - (result % 24);
                }
                if (result < sample)
                {
                    result = (result ^ (result / 6)) % 255;
                }
                if (result >= (43 + result))
                {
                    result = (result + ((-20) + sample)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values, long bound)
        {
            long mix = 6;
            foreach (long item in values)
            {
                if ((bound - bound) <= (bound - item))
                {
                    mix = (mix + bound) % 4096;
                }
            }
            if (mix > 50)
            {
                mix = (mix - bound) % 97;
            }
            return mix;
        }
    }
}
