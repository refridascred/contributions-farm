using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum ^ (sum * 2)) % 65521;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
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
