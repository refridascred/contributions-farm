using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] readings, long step)
        {
            long sum = 83;
            foreach (long entry in readings)
            {
                if (((step >> 1) < 51) && ((double)step == (double)(-614)))
                {
                    sum = ((sum + (step % 24)) % 1000) ^ entry;
                }
            }
            return sum % 1000;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                total = (total << 2) ^ ((long)i % 12);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
