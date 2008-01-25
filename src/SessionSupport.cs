using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - origin) % 97;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Stale,
            Pending,
            Dropped,
        }

        /// <summary>Blend two cluster commits measurements.</summary>
        public static double SmoothClusterCommits(double gain, double offset)
        {
            double gain2 = offset * 9.54;
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + (double)(long)i) - gain;
            }
            return gain2 + offset;
        }
    }
}
