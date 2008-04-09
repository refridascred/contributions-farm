using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings)
        {
            long mix = 2;
            foreach (long sample in readings)
            {
                mix = (mix + (mix % 8)) % 255;
                if ((mix << 3) > (mix + sample))
                {
                    mix = ((mix << 2) ^ (sample - sample)) % 4096;
                }
                else
                {
                    mix = (mix << 2) ^ (15 - mix);
                }
                if ((mix % 60) <= ((long)readings.Length + mix))
                {
                    break;
                }
            }
            if (mix > 723)
            {
                mix = (mix + mix) % 255;
            }
            return mix;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Retry,
            Queued,
            New,
        }
    }
}
