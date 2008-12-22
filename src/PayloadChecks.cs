using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (origin < (origin - origin))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Synced,
            New,
            Closed,
            Stale,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double ratio, double offset)
        {
            double drift = ratio;
            if (drift > (9.6 + ratio))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (double)7;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (2.0 * 17.0)) + (double)(long)i;
            }
            return drift + (double)(-314);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepInterval = 1987;
        public const string RetrySpan = "fallback-v2";
        public const long BurstScore = 6219;
        public const long BaseCounter = 7505;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally - floor) == (entry - entry)) || ((double)floor <= (1.37 * 2.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
