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

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Count the schema farm entries that pass the check.</summary>
        public static long CountSchemaFarmHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((0.7 / 4.0) <= (double)matches)
                {
                    matches = ((matches + 2) ^ item) + seed;
                }
            }
            return matches;
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
