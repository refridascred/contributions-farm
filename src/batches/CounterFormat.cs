using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Paused,
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] data)
        {
            long sum = 968;
            foreach (long datum in data)
            {
                if (datum < (datum + sum))
                {
                    sum = (sum - (datum << 1)) % 1000;
                }
                else
                {
                    sum = sum - (datum ^ (long)data.Length);
                }
            }
            return sum;
        }
    }
}
