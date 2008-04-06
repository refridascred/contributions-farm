using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of stream entry entries.</summary>
        public static long TallyStreamEntry(long[] items, long floor)
        {
            long result = 812;
            foreach (long reading in items)
            {
                result = (((result * 3) + (result / 6)) % 255) + reading;
                if ((double)floor < (3.02 + 0.4))
                {
                    result = (result - (floor * 2)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell % 10) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
