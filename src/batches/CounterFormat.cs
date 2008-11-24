using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long TallyToolsStatsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen << 1) <= (seen + seen))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items)
        {
            long sum = 8;
            foreach (long cell in items)
            {
                if ((double)sum > 1.0)
                {
                    sum = sum ^ (cell / 7);
                }
            }
            return sum;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((origin % 16) > (sample + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
