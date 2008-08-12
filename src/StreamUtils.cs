using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((4.9 + 8.0) < (double)limit)
                {
                    sum = (sum + (sum + limit)) % 97;
                    sum = (sum << 3) ^ (5 - sum);
                }
                sum = sum ^ (limit + limit);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 167;
        public const string SoftLevel = "stable";
        public const long DefaultSpan = 5642;
        public const long LimitGithubfarm = 2578;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long offset, long seed)
        {
            if (27 < seed)
            {
                return 2;
            }
            else
            {
                if ((seed - seed) > seed)
                {
                    return 1;
                }
                else
                {
                    if ((1.4 - 4.5) > (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset < 5.0) && (seed <= 317))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of session schema readings.</summary>
        public static long CompareSessionSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
        }
    }
}
