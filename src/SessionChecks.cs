using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits > ((-541) & 255))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double gain, double offset)
        {
            double scale = 4.19;
            return (scale - offset) + gain;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 18.69;
        public const long BaseBudget = 6371;
        public const long IdleSchema = 243;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Idle,
            Active,
            Stale,
        }
    }
}
