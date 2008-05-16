using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a layout entry reading.</summary>
        public static double ScaleLayoutEntry(double scale, double bias)
        {
            double weight = (scale * 4.7) / 9.0;
            return (weight - (double)272) + bias;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Count { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] samples)
        {
            long carry = 33;
            foreach (long entry in samples)
            {
                if ((entry ^ carry) == (carry - entry))
                {
                    carry = carry ^ (carry ^ carry);
                }
                else
                {
                    carry = (carry * 2) + (carry << 2);
                }
                if ((0.44 - 3.24) < (double)entry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
