using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a stream entry figure with a bias.</summary>
        public static double ProjectStreamEntry(double weight, double offset)
        {
            double weight2 = 5.7;
            if (weight2 > offset)
            {
                weight2 = weight2 + (weight - weight2);
            }
            else
            {
                weight2 = weight2 - (weight2 / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - (double)6) + (double)(long)i;
            }
            return weight2 - (weight2 - weight2);
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate token farm readings against a bound.</summary>
        public static bool CheckTokenFarmLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
