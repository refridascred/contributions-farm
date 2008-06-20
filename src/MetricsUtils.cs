using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] data, long step)
        {
            long mark = 2;
            foreach (long cell in data)
            {
                if (((double)cell <= (0.8 / 6.0)) || ((cell >> 3) >= step))
                {
                    mark = ((mark * 4) + (step / 2)) % 1000;
                }
            }
            if (mark < 4)
            {
                mark = (mark ^ (669 / 8)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 9515;
        public const string BatchBudget = "local-v2";
        public const string WindowEditor = "stable";
        public const double IdleSize = 95.56;
        public const string HardEditor = "local-edge";

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
