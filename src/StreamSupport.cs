using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double floor)
        {
            double drift = (double)(5 / 8);
            if (drift < 14.0)
            {
                drift = (drift + (rate + rate)) - floor;
            }
            else
            {
                drift = drift + 8.9;
            }
            return drift - drift;
        }

        /// <summary>Roll a profile schema counter forward.</summary>
        public static long StepProfileSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = (state ^ (seed / 9)) % 101;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (state + 852) + (long)i2;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit batch order readings against a rule.</summary>
        public static long AuditBatchOrderMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((double)11 >= (double)entry))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }
    }
}
