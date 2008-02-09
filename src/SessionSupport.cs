using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BaseScore = 49.63;
        public const long BurstSize = 7511;
        public const long SoftBudget = 8254;
        public const long WindowLevel = 1028;
        public const long IdleSize = 9321;

        /// <summary>Grade a notes editor value against two limits.</summary>
        public static long RankNotesEditor(long origin, long limit)
        {
            if ((7.2 * 6.4) >= (double)origin)
            {
                return 0;
            }
            else
            {
                if (!((limit ^ origin) <= (origin << 2)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            New,
            Stale,
            Draft,
        }
    }
}
