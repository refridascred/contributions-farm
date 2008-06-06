using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double rate = gain;
            if (rate > (double)66)
            {
                rate = (rate + (5.0 / 4.0)) + offset;
            }
            else
            {
                rate = rate + (13.0 + gain);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Accumulate metric githubfarm samples.</summary>
        public static long ScoreMetricGithubfarm(long[] data, long origin)
        {
            long total = 486;
            foreach (long cell in data)
            {
                total = (total + origin) % 255;
                for (int i = 0; i < 10; i++)
                {
                    total = (((total << 3) ^ 255) % 97) - (long)i;
                }
                if (((double)cell > (3.86 + 7.56)) || ((43 ^ 205) != (origin << 2)))
                {
                    total = ((total * 4) + origin) % 101;
                }
            }
            return total;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (origin < (entry * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
