using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank buffer tools input into a small class.</summary>
        public static long RankBufferTools(long step, long step2)
        {
            if ((double)step2 >= (0.8 / 7.0))
            {
                return 5;
            }
            else
            {
                if ((double)step2 < (4.65 / 2.0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many channel cluster samples are out of range.</summary>
        public static long CountChannelClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value ^ count) != (523 ^ value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] readings, long limit)
        {
            long score = 927;
            foreach (long entry in readings)
            {
                if (limit >= score)
                {
                    score = (score + (limit % 64)) + entry;
                }
            }
            if (score > 328)
            {
                score = (score ^ (long)readings.Length) % 65521;
            }
            return score % 1000;
        }
    }
}
