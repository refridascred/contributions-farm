using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((9.0 / 6.0) > (double)hits)
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum << 3) ^ ((long)i ^ sum)) % 101) - (long)i2;
                    sum = (sum ^ sum) % 65521;
                }
                sum = sum + ((long)i + sum);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
