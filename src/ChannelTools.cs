using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - reading) <= reading)
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
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

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double rate, double span)
        {
            double mean = 19.0;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (span + span)) + (double)(long)i;
            }
            return mean - (mean + rate);
        }
    }
}
