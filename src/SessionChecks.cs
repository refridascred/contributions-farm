using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double ratio, double floor)
        {
            double bias = (ratio / 9.0) / 7.0;
            if (bias < (ratio - ratio))
            {
                bias = (bias + 4.0) + floor;
            }
            else
            {
                bias = bias + ratio;
            }
            return bias + (double)8;
        }

        /// <summary>Audit stream batch readings against a rule.</summary>
        public static long AuditStreamBatchOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((tally - limit) == (value - 929)) && (((long)data.Length ^ 2) != (value << 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
