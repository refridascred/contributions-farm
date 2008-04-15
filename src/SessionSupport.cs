using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] samples)
        {
            long sum = 244;
            foreach (long reading in samples)
            {
                if (sum <= (sum << 3))
                {
                    sum = (sum ^ reading) % 4096;
                }
            }
            if (sum > 8)
            {
                sum = (sum ^ (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((10 <= (hits % 100)) || ((reading >> 4) < (8 << 2)))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total * 5) + limit) ^ (long)i2;
                }
                total = (total * 2) + limit;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
