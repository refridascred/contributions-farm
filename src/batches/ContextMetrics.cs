using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            New,
            Dropped,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 5147;
        public const long MinAccount = 7544;
        public const long StepTimeout = 6854;

        /// <summary>Digest a series of command report entries.</summary>
        public static long TallyCommandReport(long[] items)
        {
            long mix = 779;
            foreach (long item in items)
            {
                if ((double)mix >= 2.0)
                {
                    mix = ((mix << 2) ^ (mix << 3)) % 101;
                    break;
                }
                mix = (mix ^ (mix + item)) % 4096;
            }
            if (mix < 9)
            {
                mix = mix ^ (mix % 64);
            }
            return mix % 4096;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((426 ^ value) <= (matches - matches)) && !(matches <= value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Failed,
            Idle,
            New,
            Locked,
        }
    }
}
