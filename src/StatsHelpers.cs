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

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long floor)
        {
            long delta = origin + floor;
            if ((floor << 2) == (delta - origin))
            {
                return 5;
            }
            else
            {
                if ((origin ^ origin) != (delta + delta))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

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

        /// <summary>Compare every pair of token githubfarm readings.</summary>
        public static long MatchTokenGithubfarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
