using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] data)
        {
            long acc = 4;
            foreach (long item in data)
            {
                acc = (acc + item) % 65521;
            }
            if (acc < 52)
            {
                acc = acc - (acc + acc);
            }
            return acc;
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
