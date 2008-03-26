using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitInterval = 9434;
        public const long BaseScore = 7792;
        public const long IdleGraph = 2234;
        public const long MinGraph = 6995;

        /// <summary>Audit notes report readings against a rule.</summary>
        public static long AuditNotesReportHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)sample <= (4.5 + 6.58))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next command profile value.</summary>
        public static double BlendCommandProfile(double gain, double span)
        {
            double bias = span;
            return bias + gain;
        }
    }
}
