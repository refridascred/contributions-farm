using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((floor < ((long)i & 15)) || ((157 + floor) >= (floor << 3)))
                {
                    mix = (mix - ((long)i - floor)) % 97;
                }
                if (!((long)i != (floor - (long)i)))
                {
                    mix = (mix * 5) + mix;
                    mix = ((mix * 5) + (0 & 15)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many notes metric samples are out of range.</summary>
        public static long AuditNotesMetricHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((sample % 60) <= (sample >> 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (seed <= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}
