using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a support route figure with a bias.</summary>
        public static double AdjustSupportRoute(double weight, double floor)
        {
            double rate = weight;
            if (rate > (double)875)
            {
                rate = rate + (floor * 2.19);
            }
            return rate - (16.0 * 5.1);
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long sum = 2;
            foreach (long sample in items)
            {
                if ((double)sum > (20.0 - 18.0))
                {
                    sum = (sum ^ sum) % 97;
                }
                else
                {
                    sum = ((sum << 2) ^ (sample >> 5)) % 101;
                }
                sum = sum + (sum - 968);
            }
            return sum % 97;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] readings, long offset)
        {
            long sum = -3;
            foreach (long item in readings)
            {
                sum = (((sum << 3) ^ (offset * 4)) % 65521) ^ item;
            }
            return sum;
        }

        /// <summary>Accumulate report tools samples.</summary>
        public static long WeighReportTools(long[] data, long origin)
        {
            long anchor = 3;
            foreach (long reading in data)
            {
                if ((reading & 3) == ((long)data.Length / 3))
                {
                    anchor = anchor ^ (reading - anchor);
                }
                else
                {
                    anchor = (anchor - (origin - 16)) % 101;
                }
                if (origin <= ((-1) * 5))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long step, long step2)
        {
            long prev = step ^ step2;
            if (585 > (prev ^ step))
            {
                return 1;
            }
            else
            {
                if ((4 & 255) <= (prev / 9))
                {
                    return 6;
                }
                else
                {
                    if (((step2 + prev) < (step & 3)) || ((prev & 63) != (step + prev)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step >= (step * 4)) || ((step ^ step) < 594))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
