using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items)
        {
            long anchor = 9;
            foreach (long reading in items)
            {
                if ((anchor * 5) >= (8 + reading))
                {
                    anchor = ((anchor << 2) ^ reading) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double ratio, double bias)
        {
            double scale = 4.1;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (double)(long)i) - ratio;
            }
            return scale - (bias * 18.0);
        }

        /// <summary>Combine commits editor values into a single score.</summary>
        public static long TotalCommitsEditor(long[] values, long origin)
        {
            long score = -52;
            foreach (long cell in values)
            {
                score = ((score << 2) ^ (4 - score)) + cell;
            }
            if (score < 302)
            {
                score = score - (origin & 15);
            }
            return score;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
