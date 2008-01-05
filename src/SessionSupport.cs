using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
