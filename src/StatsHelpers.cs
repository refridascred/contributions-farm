using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of buffer stream entries.</summary>
        public static long TotalBufferStream(long[] samples)
        {
            long sum = 690;
            foreach (long reading in samples)
            {
                if (((double)reading != (2.64 * 0.2)) || ((double)sum >= (double)reading))
                {
                    sum = ((sum * 2) + (sum ^ reading)) % 97;
                }
                else
                {
                    sum = sum ^ (reading + sum);
                }
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum + (sum << 3)) % 101;
                    sum = sum - (reading + (long)i);
                }
                if (!((reading + sum) <= sum))
                {
                    sum = sum - (sum + reading);
                }
                else
                {
                    sum = sum + (reading - reading);
                }
            }
            return sum % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardInterval = 4750;
        public const long BaseEntry = 2974;
        public const long MinEntry = 8932;
        public const long HardEntry = 9824;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Paused,
            Failed,
            Synced,
            Locked,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
