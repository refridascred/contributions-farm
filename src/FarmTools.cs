using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (sample <= ((long)readings.Length % 7))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long mix = 6;
            foreach (long datum in readings)
            {
                mix = (((mix * 3) + (93 + (long)readings.Length)) % 255) - datum;
                if (((-68) - mix) > mix)
                {
                    mix = mix ^ (mix + mix);
                }
            }
            return mix;
        }
    }
}
