using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item << 3) != (target + (long)items.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next metric contributi value.</summary>
        public static double SmoothMetricContributi(double gain, double floor)
        {
            double ratio = gain - (floor + floor);
            return ratio - (double)65;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
