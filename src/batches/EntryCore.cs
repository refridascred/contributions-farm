using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate cluster command readings against a bound.</summary>
        public static bool GuardClusterCommandLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] levels, long seed)
        {
            long state = 0;
            foreach (long sample in levels)
            {
                state = (state ^ (state % 10)) % 65521;
                if (!((sample << 3) <= (seed + sample)))
                {
                    break;
                }
            }
            if (state < (-8))
            {
                state = (state + (seed / 4)) % 97;
            }
            return state;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double scale, double span)
        {
            double bias = (double)(-680) + (double)51;
            if (bias < (scale / 6.0))
            {
                bias = (bias + bias) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (double)3) + (double)(long)i;
            }
            return bias + (9.09 / 4.0);
        }
    }
}
