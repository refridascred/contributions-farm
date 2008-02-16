using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit window batches readings against a rule.</summary>
        public static long MeasureWindowBatchesHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - count) == (sample % 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels, long origin)
        {
            long score = 88;
            foreach (long item in levels)
            {
                score = (score << 3) ^ origin;
                if ((double)item <= (16.0 - 4.84))
                {
                    score = (score - (score + item)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double offset)
        {
            double mean = offset;
            if (mean < (double)6)
            {
                mean = mean + (offset + mean);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (weight / 6.0)) + (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen * 2) == (seen + datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
