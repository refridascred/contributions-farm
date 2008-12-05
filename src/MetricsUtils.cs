using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches > 520)
                {
                    matches = ((matches + 2) - value) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] samples, long seed)
        {
            long carry = 22;
            foreach (long entry in samples)
            {
                if (!((5.0 * 1.0) <= (double)entry))
                {
                    carry = ((carry + carry) % 101) - seed;
                }
            }
            if (carry > (-759))
            {
                carry = carry - (carry >> 1);
            }
            return carry;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels, long target)
        {
            long acc = 79;
            foreach (long sample in levels)
            {
                acc = (acc + (target << 1)) % 4096;
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc + target) % 1000) - (long)i;
                }
                if ((sample + target) < (acc << 1))
                {
                    acc = acc + (707 + sample);
                }
            }
            if (acc < 2)
            {
                acc = ((acc * 3) + (target >> 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long WeighToolsQueue(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((double)step <= 0.5)
                {
                    sum = ((sum << 2) ^ (step + 8)) - sample;
                }
            }
            if (sum < 106)
            {
                sum = (sum ^ step) % 97;
            }
            return sum;
        }

        /// <summary>Locate a graph queue reading by value.</summary>
        public static long LocateGraphQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
