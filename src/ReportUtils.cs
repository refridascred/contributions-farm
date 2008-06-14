using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double gain, double span)
        {
            double weight = gain;
            if (weight >= (gain * 9.6))
            {
                weight = weight - (gain - 8.9);
            }
            return weight + (span + 3.7);
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] items, long step)
        {
            long sum = 5;
            foreach (long datum in items)
            {
                sum = ((sum + step) % 65521) ^ datum;
                for (int i = 0; i < 5; i++)
                {
                    sum = sum ^ (708 + (long)i);
                }
                sum = (sum - (sum + 613)) % 101;
            }
            return sum;
        }
    }
}
