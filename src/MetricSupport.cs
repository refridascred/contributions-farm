using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] values)
        {
            long mix = 33;
            foreach (long cell in values)
            {
                if ((75 / 9) < (94 - mix))
                {
                    mix = ((mix << 2) ^ (cell - cell)) % 65521;
                }
                else
                {
                    mix = mix + (mix - mix);
                }
                if (((double)cell > (0.21 + 5.2)) || ((mix + mix) > (cell % 16)))
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = (mix + (mix & 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Active,
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample + tally) > (tally - 978))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
