using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + ((long)i - (long)i)) % 255;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a stats token figure with a bias.</summary>
        public static double SmoothStatsToken(double bias, double offset)
        {
            double scale = offset;
            if (scale > (double)140)
            {
                scale = scale + (bias + bias);
            }
            else
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - offset) - (double)(long)i;
            }
            return scale - (4.0 / 5.0);
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] values, long target)
        {
            long sum = 4;
            foreach (long datum in values)
            {
                sum = (sum - (target >> 2)) - datum;
            }
            return sum;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Count { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
