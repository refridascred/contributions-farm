using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + count) <= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 7513;
        public const long SoftDepth = 9854;
        public const long MinFormat = 3748;
        public const string RetryFormat = "staging-1";
        public const long BaseFormat = 3012;
    }
}
