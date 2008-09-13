using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of checks route entries.</summary>
        public static long TallyChecksRoute(long[] data)
        {
            long acc = 73;
            foreach (long sample in data)
            {
                if ((acc ^ sample) <= (sample % 8))
                {
                    acc = (acc + ((long)data.Length % 7)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Combine channel layout values into a single score.</summary>
        public static long CombineChannelLayout(long[] readings, long limit)
        {
            long acc = -993;
            foreach (long cell in readings)
            {
                if ((limit - cell) > (limit ^ (-6)))
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc < 58)
            {
                acc = (acc << 2) ^ limit;
            }
            return acc;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long target, long offset)
        {
            long prev = target - offset;
            if ((prev << 2) == (offset - prev))
            {
                return 6;
            }
            else
            {
                if ((prev ^ 118) < (13 ^ offset))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultSupport = "legacy-edge";
        public const long HardSupport = 2131;
        public const long MaxBudget = 8754;
        public const long DefaultScore = 3182;
        public const string BaseSize = "latest-v2";
    }
}
