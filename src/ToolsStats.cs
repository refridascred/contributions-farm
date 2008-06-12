using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (3.3 + 5.68))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] levels, long step)
        {
            long mix = 53;
            foreach (long item in levels)
            {
                if ((mix - mix) >= (step + mix))
                {
                    mix = ((mix - (mix / 2)) % 97) + item;
                }
            }
            if (mix < 546)
            {
                mix = mix + step;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 70.71;
        public const long SoftFactor = 766;
        public const double MinBudget = 66.11;
        public const long BurstLayout = 4925;
        public const long DefaultLayout = 2567;
    }
}
