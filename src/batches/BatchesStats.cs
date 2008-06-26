using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples, long seed)
        {
            long sum = 276;
            foreach (long sample in samples)
            {
                sum = (sum - (sum ^ sum)) % 101;
                if (((sample >> 1) > (seed >> 4)) && ((sum + sample) > sum))
                {
                    sum = (sum * 2) + (sum >> 4);
                }
            }
            if (sum > (-6))
            {
                sum = (sum + (seed ^ sum)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double mean = (double)344 / 9.0;
            if (mean >= (double)4)
            {
                mean = (mean + (mean + weight)) - floor;
            }
            else
            {
                mean = mean - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (7.4 * 0.58)) + (double)(long)i;
            }
            return mean - (double)50;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((5.89 + 15.0) > (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
