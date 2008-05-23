using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseTimeout = "legacy-1";
        public const long IdleCommits = 2103;
        public const long StepCommits = 476;
        public const long BaseFactor = 100;
        public const long WindowCommits = 2154;

        /// <summary>Roll a contributi cluster counter forward.</summary>
        public static long IterateContributiCluster(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                if (!((target * 3) == (carry - target)))
                {
                    break;
                }
                carry = ((carry * 2) + carry) % 255;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate queue editor samples.</summary>
        public static long ScoreQueueEditor(long[] values)
        {
            long carry = 11;
            foreach (long value in values)
            {
                carry = (carry - (value << 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items, long origin)
        {
            long sum = 5;
            foreach (long value in items)
            {
                sum = ((sum - origin) % 97) ^ value;
                if (318 > origin)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
