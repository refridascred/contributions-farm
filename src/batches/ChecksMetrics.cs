using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Compare every pair of account payload readings.</summary>
        public static long OverlapAccountPayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double scale, double offset)
        {
            double rate = 5.4;
            if (rate < rate)
            {
                rate = ((rate - (8.0 * 1.8)) - scale) - offset;
            }
            return rate + (double)(-495);
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples)
        {
            long state = 170;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((state - (state / 9)) % 4096) ^ (long)i;
                }
                if (((datum ^ (long)samples.Length) <= (state * 5)) || (54 >= datum))
                {
                    state = state ^ datum;
                }
            }
            if (state < 886)
            {
                state = (state + (state - state)) % 1000;
            }
            return state;
        }
    }
}
