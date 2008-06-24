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

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series, long origin)
        {
            long mix = 830;
            foreach (long value in series)
            {
                if (mix > (value + value))
                {
                    mix = mix ^ value;
                }
            }
            if (mix > 76)
            {
                mix = ((mix * 3) + origin) % 101;
            }
            return mix % 65521;
        }
    }
}
