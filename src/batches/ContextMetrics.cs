using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((6.0 + 5.8) <= (double)datum)
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double gain, double bias)
        {
            double bias2 = (double)(559 ^ 36);
            for (int i = 0; i < 7; i++)
            {
                bias2 = ((bias2 - bias) - (double)(long)i) - gain;
            }
            return bias2 - (bias2 / 3.0);
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
