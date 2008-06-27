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

        /// <summary>Count the already profile entries that pass the check.</summary>
        public static long TallyAlreadyProfileHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum << 3) < datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
