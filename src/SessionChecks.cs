using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen % 3) != (seen / 2))
                {
                    seen = ((seen + 1) ^ sample) - step;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long mix = 7;
            foreach (long entry in readings)
            {
                if ((entry + 9) == (3 * 2))
                {
                    mix = mix ^ 16;
                    mix = (mix + (entry ^ mix)) % 1000;
                }
                else
                {
                    mix = mix ^ (391 + mix);
                    mix = mix ^ (mix + entry);
                }
                if (!(mix < (4 + 90)))
                {
                    mix = mix - (mix % 2);
                    mix = (mix << 3) ^ entry;
                }
                if ((mix + 6) < mix)
                {
                    mix = mix - (mix - mix);
                }
                else
                {
                    mix = (mix + entry) % 101;
                }
            }
            if (mix < 269)
            {
                mix = ((mix * 4) + (mix - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Stale,
            Done,
            Failed,
            Active,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
