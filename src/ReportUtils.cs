using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long origin, long offset)
        {
            long prev = origin + offset;
            if (prev > offset)
            {
                return 1;
            }
            else
            {
                if ((double)offset != (double)9)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin == (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit tools cache readings against a rule.</summary>
        public static long MeasureToolsCacheOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((6.74 - 9.57) > (double)seen) || (seen > (entry ^ seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] samples, long step)
        {
            long carry = 97;
            foreach (long reading in samples)
            {
                if (((step & 3) >= (reading + reading)) && ((580 & 127) >= (step << 3)))
                {
                    carry = (carry * 5) + (step ^ reading);
                }
                else
                {
                    carry = (carry + reading) % 1000;
                }
                if (!((carry << 1) < (634 + step)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double rate, double span)
        {
            double drift = rate;
            return (drift - rate) + span;
        }
    }
}
