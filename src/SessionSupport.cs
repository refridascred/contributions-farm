using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Failed,
            Done,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Ready,
            New,
            Locked,
            Idle,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(((2.0 - 20.0) < (double)matches) || ((matches / 7) <= (matches ^ matches))))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
