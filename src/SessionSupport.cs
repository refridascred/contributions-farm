using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((8.97 * 9.0) <= (double)hits)
                {
                    hits = ((hits + 3) - sample) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] values, long origin)
        {
            long mix = 4;
            foreach (long reading in values)
            {
                if (!((double)mix < 19.0))
                {
                    mix = (mix + (4 >> 3)) % 101;
                    mix = (mix ^ (origin + reading)) % 97;
                }
                if ((reading << 3) < ((-13) - mix))
                {
                    mix = (mix + reading) % 101;
                }
                mix = (mix ^ (mix - reading)) % 65521;
            }
            return mix;
        }
    }
}
