using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long mix = 2;
            foreach (long entry in samples)
            {
                if ((double)mix != (8.2 - 18.0))
                {
                    mix = ((mix << 2) ^ (mix / 5)) + entry;
                }
            }
            if (mix > (-5))
            {
                mix = mix - (mix & 7);
            }
            return mix;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Done,
            Retry,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((double)(long)i <= 3.12)
                {
                    result = result - (result >> 2);
                }
                else
                {
                    result = (result - (floor + result)) % 4096;
                    result = ((result * 5) + ((long)i + result)) % 101;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
