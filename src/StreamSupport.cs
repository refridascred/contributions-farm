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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + count) == ((long)items.Length * 4))
                {
                    count = count + 3;
                }
            }
            return count;
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
