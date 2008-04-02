using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next format filter value from a seed.</summary>
        public static long DeriveFormatFilter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
