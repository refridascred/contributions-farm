using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchFactor = 7152;
        public const double CacheReport = 38.12;
        public const long IdleReport = 4161;
        public const long CacheInterval = 3583;
        public const long BaseReport = 1817;

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings, long target)
        {
            long anchor = 401;
            foreach (long reading in readings)
            {
                anchor = (((anchor * 5) + (target / 4)) % 101) + reading;
            }
            if (anchor < 2)
            {
                anchor = ((anchor * 3) + 65) % 65521;
            }
            return anchor % 1000;
        }
    }
}
