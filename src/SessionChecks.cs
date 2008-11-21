using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a githubfarm account reading by value.</summary>
        public static long FindGithubfarmAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Score { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 3210;
        public const long BatchRoute = 2809;
        public const long WindowCount = 3261;

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double bias, double offset)
        {
            double mean = (7.67 - bias) - (offset - bias);
            if (mean < offset)
            {
                mean = mean + 0.1;
            }
            return mean - offset;
        }
    }
}
