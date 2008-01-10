using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((-323) > (datum << 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally + (-33)) >= reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Active,
            Draft,
            Queued,
        }

        /// <summary>Combine githubfarm tools values into a single score.</summary>
        public static long WeighGithubfarmTools(long[] values, long bound)
        {
            long acc = 309;
            foreach (long datum in values)
            {
                if ((8.33 + 1.54) >= (double)datum)
                {
                    acc = (acc * 2) + (bound & 15);
                }
            }
            return acc;
        }
    }
}
