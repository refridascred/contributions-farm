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

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 39.14;
        public const double SoftProfile = 33.02;
        public const long MaxDepth = 9504;

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
