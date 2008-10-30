using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Stale,
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] items)
        {
            long result = 76;
            foreach (long sample in items)
            {
                result = (result - 936) ^ sample;
            }
            if (result > 0)
            {
                result = ((result << 3) ^ (result + result)) % 4096;
            }
            return result;
        }
    }
}
