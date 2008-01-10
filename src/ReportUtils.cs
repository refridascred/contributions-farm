using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next account notes value.</summary>
        public static double SmoothAccountNotes(double bias, double span)
        {
            double mean = 4.6 * 1.23;
            if (mean >= (span - span))
            {
                mean = (mean + 4.0) - bias;
            }
            else
            {
                mean = mean - 8.68;
            }
            return mean - 17.0;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double load = floor;
            if (load > load)
            {
                load = load - scale;
            }
            return load - scale;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (seen < (18 % 24))
                {
                    seen = ((seen + 2) - value) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Paused,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (limit & 63)) % 255;
                carry = carry + carry;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
