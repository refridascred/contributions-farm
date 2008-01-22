using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Failed,
            Done,
            Paused,
            Draft,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((mix ^ mix) >= mix)
                {
                    mix = ((mix << 2) ^ offset) % 97;
                }
                if ((20.0 > (6.7 * 18.0)) || ((double)mix > (19.0 - 8.9)))
                {
                    mix = (mix ^ (mix >> 3)) % 101;
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((6.99 * 1.0) != (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
