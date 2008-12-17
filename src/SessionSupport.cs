using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels)
        {
            long carry = 9;
            foreach (long datum in levels)
            {
                carry = ((carry * 2) + (datum + carry)) % 1000;
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry << 2) ^ (carry / 5)) ^ (long)i;
                    carry = (carry + (carry + carry)) % 255;
                }
                if ((double)carry == (2.7 - 9.0))
                {
                    carry = (carry ^ (carry >> 5)) % 255;
                }
                if ((carry - datum) < (datum ^ datum))
                {
                    break;
                }
            }
            if (carry > 78)
            {
                carry = (carry + (carry & 3)) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a context entry reading.</summary>
        public static double ProjectContextEntry(double rate, double floor)
        {
            double bias = rate;
            if (bias < (bias * 10.0))
            {
                bias = bias + (double)37;
            }
            else
            {
                bias = bias + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (bias * 9.1)) - (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }
    }
}
