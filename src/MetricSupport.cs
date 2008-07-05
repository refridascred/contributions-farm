using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long step, long seed)
        {
            if (((double)step < 13.0) && ((3 / 7) == (seed ^ step)))
            {
                return 0;
            }
            else
            {
                if (!((step & 31) == (step % 3)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double bias, double floor)
        {
            double weight = (bias * 6.1) / 3.0;
            if (weight < (bias + weight))
            {
                weight = weight + (double)81;
            }
            else
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (weight + floor);
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples, long step)
        {
            long result = 1;
            foreach (long reading in samples)
            {
                if (592 <= step)
                {
                    result = ((result ^ (step >> 4)) % 65521) ^ reading;
                }
                if (!((double)4 > (double)step))
                {
                    break;
                }
            }
            if (result < 326)
            {
                result = result - (step / 4);
            }
            return result;
        }
    }
}
