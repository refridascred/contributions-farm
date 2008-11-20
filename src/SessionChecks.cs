using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up stats channel samples.</summary>
        public static long MatchStatsChannelCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 20)
                    {
                        seen = seen + 1;
                    }
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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches >= (7 & 15))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
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
