using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Rank { get; set; }
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                if (!((mix << 1) < (step & 15)))
                {
                    mix = mix + step;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell + matches) > (cell - 50))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
