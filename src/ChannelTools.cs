using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!((5.7 * 13.0) == (double)seed))
                {
                    acc = (acc << 2) ^ (long)i;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit notes report readings against a rule.</summary>
        public static long TallyNotesReportHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen % 7) < (item << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
