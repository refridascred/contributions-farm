using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a schema counter figure with a bias.</summary>
        public static double ProjectSchemaCounter(double rate, double span)
        {
            double bias = (span + rate) - rate;
            if (bias >= (double)52)
            {
                bias = bias - (span - bias);
            }
            else
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + (double)0;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next batch notes value from a seed.</summary>
        public static long StepBatchNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((double)total <= 5.95)
                {
                    total = (total << 2) ^ (limit + (long)i);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
