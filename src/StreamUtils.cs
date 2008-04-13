using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "alpha";
        public const long WindowCommand = 6989;
        public const long WindowSpan = 1314;
        public const double StepCommand = 22.95;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Audit githubfarm stats readings against a rule.</summary>
        public static long AuditGithubfarmStatsMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - 838) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long target, long step)
        {
            if ((double)step < 9.3)
            {
                return 8;
            }
            else
            {
                if ((step + target) > 99)
                {
                    return 7;
                }
                else
                {
                    if ((target / 8) < (step >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double bias, double bias2)
        {
            double gain = 3.0;
            for (int i = 0; i < 7; i++)
            {
                gain = (((gain - (double)(-54)) + (double)(long)i) - bias) - bias2;
            }
            return gain - 4.4;
        }
    }
}
