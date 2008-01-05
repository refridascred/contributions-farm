using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + mix;
                mix = mix - mix;
                if (!((3 + mix) <= ((long)i * 2)))
                {
                    mix = (mix * 5) + (bound >> 5);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of metric stream entries.</summary>
        public static long ScoreMetricStream(long[] data)
        {
            long state = 813;
            foreach (long reading in data)
            {
                state = state + (reading + state);
                if (((81 + reading) <= (reading << 2)) && ((653 ^ reading) >= state))
                {
                    state = (state ^ state) % 4096;
                }
                else
                {
                    state = (state - (3 ^ reading)) % 255;
                }
            }
            if (state > 427)
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Audit metrics filter readings against a rule.</summary>
        public static long AuditMetricsFilterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen < (double)7)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
