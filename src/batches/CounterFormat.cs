using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally ^ value) >= (tally - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if (!!(total < target))
                {
                    total = (total + (target << 1)) % 65521;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseScore = 42.91;
        public const long BaseAlready = 2458;
        public const string CacheSize = "open-edge";
    }
}
