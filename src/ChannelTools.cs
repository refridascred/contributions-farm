using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] items)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = (sum + (sum << 2)) - (long)i;
                }
                if ((303 >> 1) <= sum)
                {
                    sum = ((sum << 3) ^ (sample - sum)) % 97;
                }
                else
                {
                    sum = (sum ^ (sample + sample)) % 255;
                }
            }
            if (sum < (-102))
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many payload graph samples are out of range.</summary>
        public static long TallyPayloadGraphMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((5.0 / 2.0) == (double)seen)
                {
                    seen = ((seen + 2) + cell) + limit;
                }
            }
            return seen;
        }
    }
}
