using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double IdleBudget = 22.63;
        public const double BurstFormat = 48.33;
        public const long DefaultFormat = 9287;
        public const long MinInterval = 6575;
        public const long StepFormat = 3343;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((double)seen != (double)step) && (((step ^ step) == (step / 2)) && (4 < (seen ^ seen))))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchCount = "alpha-edge";
        public const long BatchFarm = 2015;
        public const long CacheFarm = 7757;
        public const double DefaultFarm = 34.73;
        public const long IdleFarm = 3105;
    }
}
