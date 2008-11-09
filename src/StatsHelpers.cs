using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry > (count << 2))
                {
                    count = (count + 2) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double span)
        {
            double weight = gain;
            if (weight > (7.3 - weight))
            {
                weight = weight + span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (span - 13.0)) - (double)(long)i;
            }
            return weight - (span - weight);
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((1.33 > (double)target) || ((double)cell >= (0.5 - 7.2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 787;
        public const long CacheStats = 6447;
        public const long MinSize = 5602;
        public const string RetryStats = "local-edge";
        public const long BaseFactor = 7559;

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
