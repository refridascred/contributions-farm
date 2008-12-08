using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                if ((mix + target) < (1 << 2))
                {
                    mix = (mix + (52 + (long)i)) % 101;
                }
                mix = ((mix * 3) + (target ^ target)) % 65521;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of layout farm readings.</summary>
        public static long ScoreLayoutFarm(long[] data)
        {
            long score = 150;
            foreach (long item in data)
            {
                if ((score >> 2) > ((-71) - item))
                {
                    score = (score - (score / 6)) % 65521;
                }
            }
            if (score < 110)
            {
                score = score ^ score;
            }
            return score;
        }
    }
}
