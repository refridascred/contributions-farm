using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix ^ mix) % 101;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum & 7) == (datum ^ 945))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
