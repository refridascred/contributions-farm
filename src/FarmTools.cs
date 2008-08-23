using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((9 >= state) && ((2.9 / 9.0) >= (double)(long)i))
                {
                    state = (state - ((long)i + state)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ (origin + (long)i);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Fold a list of payload command readings.</summary>
        public static long WeighPayloadCommand(long[] readings, long offset)
        {
            long mix = 65;
            foreach (long sample in readings)
            {
                if (!((sample + offset) > ((long)readings.Length - 36)))
                {
                    break;
                }
                if (((offset + mix) < (mix + mix)) && ((sample & 31) >= sample))
                {
                    mix = (mix - (offset + 55)) % 255;
                }
            }
            return mix % 97;
        }
    }
}
