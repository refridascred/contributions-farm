using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (mix - ((long)i2 >> 1)) % 1000;
                    mix = (mix ^ (mix / 5)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate schema counter samples.</summary>
        public static long ScoreSchemaCounter(long[] series)
        {
            long state = 63;
            foreach (long entry in series)
            {
                state = state + (entry & 127);
                if (11.0 <= (double)entry)
                {
                    state = (state - entry) % 4096;
                }
                else
                {
                    state = (state - (75 * 4)) % 97;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of channel format readings.</summary>
        public static long OverlapChannelFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
