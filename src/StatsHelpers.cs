using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] levels, long bound)
        {
            long acc = -31;
            foreach (long reading in levels)
            {
                if ((4.5 - 9.0) != (double)reading)
                {
                    acc = (acc - (acc % 5)) - bound;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstRatio = 3937;
        public const long HardWidth = 6377;
        public const double LimitGithubfarm = 91.29;
        public const double MaxSpan = 91.02;

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowWidth = "latest-v2";
        public const long StepCommits = 7452;
        public const string BatchCommits = "primary-v2";
        public const long BatchFactor = 1498;

        /// <summary>Compare every pair of schema record readings.</summary>
        public static long CompareSchemaRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
