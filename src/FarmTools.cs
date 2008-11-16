using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] data)
        {
            long mix = 18;
            foreach (long sample in data)
            {
                if ((8.0 * 7.8) > (double)mix)
                {
                    mix = mix ^ (sample - mix);
                }
            }
            return mix;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit commits counter readings against a rule.</summary>
        public static long TallyCommitsCounterHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally - tally) <= (-76))
                {
                    tally = ((tally + 2) ^ datum) + floor;
                }
            }
            return tally;
        }
    }
}
