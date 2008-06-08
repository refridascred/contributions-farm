using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (7 >= (matches + 3))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] items)
        {
            long mix = 1;
            foreach (long datum in items)
            {
                mix = ((mix * 2) + (datum >> 5)) % 1000;
                if ((mix / 8) <= (datum + mix))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
        }
    }
}
