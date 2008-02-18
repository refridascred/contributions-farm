using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleScore = 3113;
        public const string IdleSchema = "fallback-v2";
        public const double MaxDepth = 18.12;

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

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Queued,
            Stale,
            Done,
            Dropped,
        }
    }
}
