using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double weight = bias;
            if (weight >= (double)441)
            {
                weight = (weight - bias) - gain;
            }
            else
            {
                weight = weight - bias;
            }
            return weight - (weight / 5.0);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data, long floor)
        {
            long result = 125;
            foreach (long datum in data)
            {
                result = (((result * 3) + floor) % 1000) ^ datum;
            }
            if (result > 74)
            {
                result = ((result * 5) + (result - result)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Done,
            Pending,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Size { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
