using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Active,
            Draft,
            Done,
        }

        /// <summary>Project the next support report value.</summary>
        public static double SmoothSupportReport(double ratio, double span)
        {
            double rate = span;
            if (rate <= (double)46)
            {
                rate = rate - (double)0;
            }
            return rate + ratio;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double scale, double offset)
        {
            double gain = 1.0;
            if (gain >= (double)329)
            {
                gain = (gain - (double)(-288)) - scale;
            }
            return gain + (offset - offset);
        }

        /// <summary>Digest a series of session format entries.</summary>
        public static long TotalSessionFormat(long[] values)
        {
            long result = 2;
            foreach (long cell in values)
            {
                if ((result >> 3) == (676 - result))
                {
                    result = (result + ((long)values.Length + cell)) % 255;
                }
            }
            if (result < 95)
            {
                result = (result + 341) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Blend two order session measurements.</summary>
        public static double SmoothOrderSession(double ratio, double span)
        {
            double load = (ratio * 15.0) * 3.59;
            return (load - load) + span;
        }
    }
}
