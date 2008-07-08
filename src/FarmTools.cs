using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long step)
        {
            long sum = 3;
            foreach (long item in series)
            {
                if ((item < (sum + sum)) && ((item + sum) < step))
                {
                    sum = (sum - (500 + step)) % 101;
                }
                else
                {
                    sum = sum + (sum + sum);
                }
            }
            if (sum < 4)
            {
                sum = sum - ((long)series.Length ^ step);
            }
            return sum;
        }
    }
}
