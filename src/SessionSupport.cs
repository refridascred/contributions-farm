using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
