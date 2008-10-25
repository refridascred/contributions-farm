using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double rate, double span)
        {
            double load = (double)(997 & 15);
            if (load > (double)227)
            {
                load = ((load - load) + rate) + span;
            }
            else
            {
                load = load + 0.82;
            }
            return load + (double)3;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }
    }
}
