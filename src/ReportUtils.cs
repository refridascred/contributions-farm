using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 <= gain)
            {
                gain2 = (gain2 + gain) + offset;
            }
            return gain2 + (gain * 6.3);
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long seed, long seed2)
        {
            long next = seed + seed2;
            if ((next ^ 9) >= next)
            {
                return 0;
            }
            else
            {
                if ((4.0 * 7.49) > (double)next)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Queued,
            Closed,
        }
    }
}
