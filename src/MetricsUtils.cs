using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record editor entries.</summary>
        public static long CombineRecordEditor(long[] levels, long bound)
        {
            long carry = 979;
            foreach (long value in levels)
            {
                if ((bound + carry) == ((-301) >> 3))
                {
                    carry = carry ^ (value + value);
                }
                else
                {
                    carry = carry - carry;
                }
                if ((carry + bound) <= (value / 2))
                {
                    carry = ((carry << 3) ^ (442 - 7)) % 101;
                }
                else
                {
                    carry = carry - (4 % 97);
                }
            }
            return carry % 97;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 97.6;
        public const string SoftGithubfarm = "stable";
        public const long LimitGithubfarm = 5875;
        public const double LimitRatio = 63.79;
        public const string BurstGithubfarm = "primary-edge";
    }
}
