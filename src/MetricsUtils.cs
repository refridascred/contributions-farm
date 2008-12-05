using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            New,
            Idle,
            Synced,
            Active,
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

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
