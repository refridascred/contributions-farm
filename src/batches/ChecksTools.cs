using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long result = 493;
            foreach (long datum in levels)
            {
                result = (result * 3) + (datum / 8);
            }
            return result % 4096;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!!(reading <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a farm queue reading.</summary>
        public static double AdjustFarmQueue(double weight, double bias)
        {
            double weight2 = (double)(609 * 3);
            if (weight2 > bias)
            {
                weight2 = weight2 - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - (weight * 7.8)) + (double)(long)i;
            }
            return weight2 + (weight2 + bias);
        }
    }
}
