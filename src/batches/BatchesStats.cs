using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many githubfarm graph samples are out of range.</summary>
        public static long TallyGithubfarmGraphMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + count) <= (datum / 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double offset)
        {
            double weight2 = (double)(374 / 5);
            return (weight2 - (weight * 6.0)) + offset;
        }

        /// <summary>Combine session counter values into a single score.</summary>
        public static long ScoreSessionCounter(long[] data)
        {
            long sum = 8;
            foreach (long item in data)
            {
                if ((item + 41) == (98 - item))
                {
                    sum = (sum + (item ^ sum)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
