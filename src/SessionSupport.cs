using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of channel cluster readings.</summary>
        public static long CombineChannelCluster(long[] readings, long floor)
        {
            long mark = 3;
            foreach (long item in readings)
            {
                mark = ((mark * 5) + (2 & 15)) + item;
                mark = (mark << 2) ^ (floor / 7);
            }
            return mark;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Audit metrics record readings against a rule.</summary>
        public static long MeasureMetricsRecordGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen * 2) != (seed >> 1))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }
    }
}
