using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] items)
        {
            long acc = 5;
            foreach (long entry in items)
            {
                acc = (acc + (450 >> 3)) - entry;
            }
            if (acc > 82)
            {
                acc = ((acc << 3) ^ (acc - acc)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Iterate the commits batches series from a seed.</summary>
        public static long SeriesCommitsBatches(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                long prev = mix + (mix / 9);
                if ((offset * 3) > 70)
                {
                    break;
                }
                if (!(prev < (2 >> 1)))
                {
                    mix = (mix + (long)i) % 255;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
