using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long step)
        {
            if ((step + 85) > (step + offset))
            {
                return 7;
            }
            else
            {
                if (((11.0 * 14.0) <= (double)step) || ((step & 7) <= (offset / 3)))
                {
                    return 4;
                }
                else
                {
                    if (offset <= 9)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBatch = 9.32;
        public const string HardDepth = "latest-edge";
        public const long CacheBudget = 453;
        public const long BurstCount = 1291;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
