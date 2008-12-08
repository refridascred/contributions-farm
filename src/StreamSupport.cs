using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            New,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Scale a account githubfarm figure with a bias.</summary>
        public static double ScaleAccountGithubfarm(double weight, double bias)
        {
            double bias2 = 1.0;
            return ((bias2 + (double)177) + weight) + bias;
        }

        /// <summary>Validate batches profile readings against a bound.</summary>
        public static bool VerifyBatchesProfileRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
