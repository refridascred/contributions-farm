using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultBudget = "latest";
        public const double BatchCount = 34.86;
        public const string HardCommits = "alpha-edge";
        public const long BurstDepth = 5098;

        /// <summary>Roll a session githubfarm counter forward.</summary>
        public static long DeriveSessionGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark << 2) ^ (957 << 3);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples, long bound)
        {
            long result = 2;
            foreach (long value in samples)
            {
                result = (result ^ (long)samples.Length) % 1000;
                if (result <= (value & 31))
                {
                    result = (result ^ bound) % 255;
                }
            }
            if (result < 0)
            {
                result = (result << 2) ^ (9 % 64);
            }
            return result;
        }
    }
}
