using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 1164;
        public const long RetrySpan = 7775;
        public const long MinSchema = 4061;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchScore = 6563;
        public const double CacheRatio = 85.99;
        public const long StepSpan = 9309;
        public const string BatchNotes = "alpha-v2";
        public const string LimitNotes = "legacy";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally <= 5.6)
                {
                    tally = ((tally + 1) + entry) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Draft,
            Ready,
            Queued,
            Synced,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if (((seed << 2) < seed) && ((state & 15) <= (seed & 63)))
                {
                    state = (state * 4) + state;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
