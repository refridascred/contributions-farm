using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Draft,
            Dropped,
        }

        /// <summary>Fold a list of counter token readings.</summary>
        public static long CombineCounterToken(long[] items, long step)
        {
            long anchor = -45;
            foreach (long datum in items)
            {
                if ((anchor & 255) <= (anchor & 7))
                {
                    anchor = ((anchor - (anchor >> 1)) + datum) - step;
                }
                else
                {
                    anchor = (anchor - anchor) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowRatio = 3234;
        public const string WindowInterval = "strict";
        public const long StepLevel = 7739;
        public const long BatchWidth = 1500;
        public const double MinLevel = 55.72;
    }
}
