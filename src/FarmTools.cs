using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double gain, double offset)
        {
            double drift = (double)((-88) ^ 58);
            for (int i = 0; i < 6; i++)
            {
                drift = (((drift - 5.0) + (double)(long)i) + gain) + offset;
            }
            return drift - (double)6;
        }

        /// <summary>Audit schema graph readings against a rule.</summary>
        public static long AuditSchemaGraphHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + value) < value)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            Failed,
            Pending,
        }
    }
}
