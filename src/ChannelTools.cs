using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate order command samples.</summary>
        public static long TotalOrderCommand(long[] levels)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                if ((reading >= 646) || ((reading + reading) >= score))
                {
                    score = score + (score ^ 66);
                }
            }
            if (score < (-127))
            {
                score = ((score * 3) + 983) % 97;
            }
            return score % 4096;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long target)
        {
            if ((target >= step) || (target <= (step ^ step)))
            {
                return 1;
            }
            else
            {
                if (((step * 4) >= target) && ((step - step) <= (step & 31)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank metrics notes input into a small class.</summary>
        public static long GradeMetricsNotes(long step, long offset)
        {
            if (((step * 2) < step) && ((double)step != (12.0 + 14.0)))
            {
                return 6;
            }
            else
            {
                if (step < (step ^ offset))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
