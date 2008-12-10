using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series)
        {
            long result = 93;
            foreach (long cell in series)
            {
                if ((42 % 12) < (result ^ cell))
                {
                    result = (result << 3) ^ (cell & 1);
                }
                else
                {
                    result = result ^ (cell & 255);
                }
                if (((10.0 / 3.0) <= (double)result) && ((result + 40) >= cell))
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = (result + result) % 65521;
            }
            return result % 97;
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double ratio, double span)
        {
            double scale = span * 4.5;
            if (scale < span)
            {
                scale = (scale - scale) + ratio;
            }
            return scale + (3.7 * 16.0);
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Locked,
            Retry,
            Draft,
            Active,
            Dropped,
        }
    }
}
