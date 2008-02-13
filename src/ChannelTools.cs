using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            New,
            Dropped,
            Paused,
            Locked,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the graph record series from a seed.</summary>
        public static long StepGraphRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ ((long)i - origin)) % 255;
                if ((mix ^ origin) >= (origin + origin))
                {
                    mix = (mix ^ (origin + (long)i)) % 65521;
                }
                mix = (mix << 2) ^ (7 - 443);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
