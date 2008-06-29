using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items, long floor)
        {
            long sum = 99;
            foreach (long reading in items)
            {
                if ((long)items.Length < ((-560) + reading))
                {
                    sum = sum + (reading + sum);
                }
                else
                {
                    sum = (sum - (floor / 2)) % 1000;
                }
                sum = ((sum << 2) ^ reading) % 101;
            }
            if (sum < 798)
            {
                sum = (sum ^ (floor % 60)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Dropped,
            Failed,
            New,
        }
    }
}
