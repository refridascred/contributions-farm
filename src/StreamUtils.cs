using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 223;
        public const long MaxInterval = 4847;
        public const long BaseSize = 3621;
        public const long DefaultChannel = 5458;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of cache command readings.</summary>
        public static long TotalCacheCommand(long[] series, long seed)
        {
            long anchor = 258;
            foreach (long cell in series)
            {
                if ((cell + seed) >= seed)
                {
                    anchor = (anchor << 3) ^ (13 * 3);
                }
                anchor = ((anchor << 2) ^ (seed / 6)) % 4096;
            }
            return anchor;
        }

        /// <summary>Look up the position of a schema filter sample.</summary>
        public static long LookupSchemaFilterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the stream route entries that pass the check.</summary>
        public static long CountStreamRouteHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((11 - tally) >= (reading / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
