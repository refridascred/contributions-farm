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

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] values)
        {
            long state = 0;
            foreach (long value in values)
            {
                state = (state - (value + 9)) % 101;
                state = (state - (state * 4)) % 255;
                if (!((value + state) <= (value + 5)))
                {
                    state = ((state * 4) + value) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double span)
        {
            double weight = (span + span) * 2.98;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (gain - span)) + (double)(long)i;
            }
            return weight - 8.7;
        }
    }
}
