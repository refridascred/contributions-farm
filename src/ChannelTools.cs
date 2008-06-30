using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((double)result >= (0.81 + 3.7))
                {
                    result = (result - (bound + bound)) % 97;
                    result = (result - ((long)i - result)) % 65521;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples)
        {
            long anchor = 53;
            foreach (long reading in samples)
            {
                if ((2.02 - 9.5) < (double)reading)
                {
                    anchor = (anchor << 2) ^ (reading / 3);
                }
                else
                {
                    anchor = anchor ^ (reading + anchor);
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Queued,
            Draft,
        }
    }
}
