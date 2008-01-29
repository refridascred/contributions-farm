using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate githubfarm cache readings against a bound.</summary>
        public static bool VerifyGithubfarmCacheBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] levels, long limit)
        {
            long result = -56;
            foreach (long value in levels)
            {
                if ((value + 3) > (result + result))
                {
                    result = (result + (-17)) - limit;
                }
            }
            return result;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Pending,
            New,
        }
    }
}
