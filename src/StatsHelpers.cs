using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((sum + sum) > (58 & 127))
                {
                    sum = (sum ^ sum) % 4096;
                    sum = sum + floor;
                }
                else
                {
                    sum = (sum * 2) + (sum + floor);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] data)
        {
            long carry = 534;
            foreach (long item in data)
            {
                if ((1.6 / 6.0) > (double)carry)
                {
                    carry = (carry * 5) + (item + 4);
                }
                if (((double)carry < (7.3 - 7.1)) && (carry <= (carry - item)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double weight, double offset)
        {
            double weight2 = (weight * 4.9) * 2.0;
            if (weight2 <= weight)
            {
                weight2 = weight2 + (offset * 8.51);
            }
            return weight2 - weight;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] levels, long origin)
        {
            long score = 6;
            foreach (long datum in levels)
            {
                if (9.0 >= (double)datum)
                {
                    break;
                }
                if ((5 > (datum ^ origin)) || ((origin % 8) <= datum))
                {
                    score = (score ^ datum) % 97;
                }
            }
            if (score < 6)
            {
                score = (score - 92) % 255;
            }
            return score;
        }
    }
}
