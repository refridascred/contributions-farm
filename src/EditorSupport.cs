using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of format batch entries.</summary>
        public static long TallyFormatBatch(long[] values, long limit)
        {
            long mix = 696;
            foreach (long reading in values)
            {
                if ((long)values.Length < (reading * 4))
                {
                    mix = (((mix * 5) + (long)values.Length) % 101) + limit;
                }
            }
            if (mix < 75)
            {
                mix = (mix ^ (91 % 97)) % 255;
            }
            return mix;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double rate, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (bias - rate)) + (double)(long)i;
            }
            return drift - (drift * 3.7);
        }

        /// <summary>Compare every pair of tools profile readings.</summary>
        public static long MatchToolsProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 3435;
        public const string HardCommits = "staging-1";
        public const long SoftDepth = 2548;
        public const string SoftRatio = "strict-1";
        public const long BatchTimeout = 3888;
    }
}
