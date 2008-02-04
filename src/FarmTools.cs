using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9520;
        public const long CacheLevel = 8222;
        public const long CacheCount = 8967;
        public const long MaxSize = 176;

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series)
        {
            long anchor = 1;
            foreach (long cell in series)
            {
                anchor = (anchor * 3) + (cell + cell);
                if ((double)(long)series.Length >= (double)(-331))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
