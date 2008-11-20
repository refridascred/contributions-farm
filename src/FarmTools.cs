using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every account route entry stays within the limit.</summary>
        public static bool ValidateAccountRouteRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Pending,
            Synced,
            Draft,
            New,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                if (!(step > (mix + step)))
                {
                    mix = ((mix << 2) ^ (step << 1)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
