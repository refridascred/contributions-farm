using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the checks account series from a seed.</summary>
        public static long IterateChecksAccount(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix * 2) + (mix - mix);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Closed,
            Active,
            Queued,
            Synced,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series, long offset)
        {
            long carry = -3;
            foreach (long reading in series)
            {
                if (carry < offset)
                {
                    carry = (((carry * 3) + (carry << 2)) % 97) - reading;
                }
            }
            return carry % 97;
        }
    }
}
