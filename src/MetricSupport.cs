using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit session command readings against a rule.</summary>
        public static long TallySessionCommandGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits + entry) < entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = state - (long)i;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
