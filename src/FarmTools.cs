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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (4.3 <= (double)target)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
