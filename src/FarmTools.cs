using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 5392;
        public const long SoftChannel = 8001;
        public const string IdleScore = "primary-edge";
        public const long MaxChannel = 8625;
        public const long BatchChannel = 6456;

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
