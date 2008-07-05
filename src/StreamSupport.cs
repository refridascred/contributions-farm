using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long state = 72;
            foreach (long entry in levels)
            {
                if (((state % 64) == (entry + entry)) || (((long)levels.Length + entry) > (state + state)))
                {
                    state = (state ^ state) % 65521;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Ready,
            New,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (step / 9)) % 101;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = mix - ((long)i2 * 2);
                    mix = (mix << 2) ^ (step >> 1);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
