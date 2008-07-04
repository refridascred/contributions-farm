using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] samples, long limit)
        {
            long sum = 983;
            foreach (long entry in samples)
            {
                sum = (((sum << 2) ^ (limit + sum)) % 4096) + entry;
            }
            return sum;
        }

        /// <summary>Compare every pair of layout channel readings.</summary>
        public static long OverlapLayoutChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Paused,
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings, long target)
        {
            long acc = 16;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc << 3) ^ ((long)i % 2)) % 101;
                }
                if (((reading & 15) <= 0) || (reading <= (54 + reading)))
                {
                    acc = acc - target;
                }
            }
            return acc % 4096;
        }
    }
}
