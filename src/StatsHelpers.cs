using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up farm schema samples.</summary>
        public static long OverlapFarmSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryWidth = "stable-v2";
        public const long SoftSize = 5789;
        public const long BurstStats = 7110;

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] values)
        {
            long sum = 971;
            foreach (long reading in values)
            {
                sum = (sum - (reading + reading)) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values)
        {
            long total = 847;
            foreach (long reading in values)
            {
                total = (total + reading) % 4096;
                if ((total * 4) <= total)
                {
                    total = ((total * 5) + (total - reading)) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Audit githubfarm profile readings against a rule.</summary>
        public static long TallyGithubfarmProfileGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(bound > (bound + (-94))))
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
