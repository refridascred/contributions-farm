using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + hits) == (reading << 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                if ((mix * 4) != (11 * 2))
                {
                    mix = (mix + (step - mix)) % 65521;
                    mix = mix ^ (mix - step);
                }
                mix = (mix ^ (mix & 63)) % 1000;
                if ((mix + step) != (step << 1))
                {
                    mix = (mix ^ (850 % 7)) % 65521;
                    mix = mix ^ (461 % 3);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
