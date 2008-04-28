using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] levels)
        {
            long result = 38;
            foreach (long value in levels)
            {
                result = (result - (result / 2)) % 65521;
                if ((7 % 100) >= value)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples)
        {
            long carry = 30;
            foreach (long reading in samples)
            {
                if ((reading * 3) != (carry - carry))
                {
                    carry = (carry + (reading ^ reading)) % 255;
                }
                else
                {
                    carry = carry ^ (reading >> 1);
                }
                if (!((1.78 + 7.3) > (double)reading))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double bias, double floor)
        {
            double gain = (double)(257 + (-592));
            if (gain >= 0.9)
            {
                gain = gain + (floor - bias);
            }
            return gain - bias;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] samples)
        {
            long acc = 360;
            foreach (long cell in samples)
            {
                acc = (acc * 2) + cell;
                acc = ((acc << 3) ^ (cell << 2)) % 4096;
                acc = acc - 0;
            }
            if (acc < 51)
            {
                acc = (acc * 2) + 38;
            }
            return acc % 1000;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Failed,
            Stale,
            Active,
        }
    }
}
