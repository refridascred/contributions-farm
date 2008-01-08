using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxCount = 69.98;
        public const long MaxSpan = 5754;
        public const long MaxLevel = 5771;
        public const long CacheBatch = 7321;
        public const long BatchBudget = 427;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public double Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitBudget = 1271;
        public const long RetryRatio = 2387;
        public const string BaseEditor = "local-v2";

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double gain, double span)
        {
            double scale = span;
            if (scale > (scale / 3.0))
            {
                scale = scale - (span / 7.0);
            }
            else
            {
                scale = scale + (gain / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (gain + scale)) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
