using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if (origin > result)
                {
                    result = (result ^ 5) % 65521;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
