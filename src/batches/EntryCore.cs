using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen + datum) <= 58)
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long floor, long origin)
        {
            if (!((7 - origin) <= floor))
            {
                return 8;
            }
            else
            {
                if ((origin * 3) > (9 ^ origin))
                {
                    return 4;
                }
                else
                {
                    if ((double)167 >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor > 6.1)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            New,
            Queued,
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Digest a series of account farm entries.</summary>
        public static long TallyAccountFarm(long[] samples, long limit)
        {
            long sum = 266;
            foreach (long value in samples)
            {
                if ((double)sum != (7.73 + 9.5))
                {
                    sum = ((sum << 2) ^ value) % 101;
                }
                if (63 <= (sum & 63))
                {
                    sum = (sum - (limit * 5)) % 255;
                }
                if (limit >= (value / 6))
                {
                    sum = ((sum * 3) + (limit - limit)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "stable-edge";
        public const long MinToken = 2278;
        public const long SoftFactor = 8090;
        public const string WindowRatio = "local-v2";
    }
}
