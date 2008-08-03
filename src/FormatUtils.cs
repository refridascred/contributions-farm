using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit githubfarm order readings against a rule.</summary>
        public static long AuditGithubfarmOrderMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((seen + offset) == ((-676) << 1)) || (((double)offset > (double)16) || (seen <= entry)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double gain, double floor)
        {
            double drift = (double)(-31);
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (double)(long)i) + gain) - floor;
            }
            return drift - (8.1 * 7.91);
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (limit - (long)i)) % 255;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftSize = "stable-edge";
        public const string HardScore = "alpha";
        public const long LimitEditor = 6868;
        public const long WindowEditor = 8542;
    }
}
