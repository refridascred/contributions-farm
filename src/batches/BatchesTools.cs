using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long offset2)
        {
            if ((offset2 + offset2) == (offset2 - 82))
            {
                return 4;
            }
            else
            {
                if ((double)offset <= 6.58)
                {
                    return 1;
                }
                else
                {
                    if ((offset >= (offset + offset2)) || ((8.2 - 0.1) == (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset2 / 8) > (offset2 - 8)) || ((offset2 - offset) >= (0 + 855)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double weight = 9.8;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + weight) + (double)(long)i) + floor;
            }
            return weight - (scale / 7.0);
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
