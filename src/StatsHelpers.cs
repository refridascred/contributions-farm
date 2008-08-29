using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the support account series from a seed.</summary>
        public static long StepSupportAccount(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (((sum << 3) ^ (sum << 2)) % 65521) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((item & 1) <= step) || ((double)7 > (double)step))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
