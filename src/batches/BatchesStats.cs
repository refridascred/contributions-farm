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

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((mark - mark) >= (offset + offset)))
                {
                    mark = (mark - (offset - mark)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
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
