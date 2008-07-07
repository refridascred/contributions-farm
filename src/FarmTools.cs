using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] series, long floor)
        {
            long acc = 197;
            foreach (long sample in series)
            {
                if ((floor * 2) < (acc % 100))
                {
                    acc = ((acc << 2) ^ (sample * 3)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate graph githubfarm readings against a bound.</summary>
        public static bool CheckGraphGithubfarmRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
