using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor ^ ((long)i + 7)) % 65521;
                anchor = (anchor ^ (floor + floor)) % 101;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long mix = 6;
            foreach (long item in samples)
            {
                mix = mix + item;
                if (mix >= (item * 5))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = (mix - (4 + item)) % 65521;
                }
                if ((17.0 / 7.0) != (double)item)
                {
                    break;
                }
            }
            if (mix > 39)
            {
                mix = ((mix * 4) + mix) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Offset { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many cluster batches samples are out of range.</summary>
        public static long CountClusterBatchesHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally + tally) <= (item / 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Active,
            Locked,
            Ready,
            Closed,
            Stale,
        }
    }
}
