using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double weight, double bias)
        {
            double weight2 = (18.0 / 7.0) * 6.4;
            if (weight2 > (double)3)
            {
                weight2 = (weight2 + (weight2 * 5.3)) - weight;
            }
            else
            {
                weight2 = weight2 + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 - (double)14) + (double)(long)i;
            }
            return weight2 + (weight2 / 9.0);
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Locked,
            Draft,
        }

        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long RollBatchSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = (result + ((long)i ^ (long)i)) % 1000;
                result = (result + floor) % 255;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
