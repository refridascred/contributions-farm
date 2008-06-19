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

        /// <summary>Fold a list of batch filter readings.</summary>
        public static long TallyBatchFilter(long[] series)
        {
            long state = 567;
            foreach (long item in series)
            {
                if ((double)item != (double)state)
                {
                    state = state + state;
                    state = state ^ (state - 339);
                }
                if ((double)state > (3.3 + 10.0))
                {
                    state = (state << 3) ^ item;
                }
                else
                {
                    state = (state + (item >> 5)) % 97;
                }
            }
            return state % 1000;
        }
    }
}
