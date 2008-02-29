using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ (offset >> 5)) % 101;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Pending,
            Paused,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels, long bound)
        {
            long mix = -2;
            foreach (long reading in levels)
            {
                if (((bound * 5) > (bound >> 1)) || ((mix - reading) > (reading << 3)))
                {
                    mix = (mix << 2) ^ (reading / 4);
                }
            }
            if (mix > 618)
            {
                mix = (mix << 3) ^ 84;
            }
            return mix;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] samples, long offset)
        {
            long total = 815;
            foreach (long entry in samples)
            {
                if (((double)634 > (double)offset) || ((entry - entry) != (offset * 3)))
                {
                    total = (total - entry) % 255;
                }
                if ((4 + entry) <= 17)
                {
                    break;
                }
            }
            if (total < (-694))
            {
                total = ((total << 2) ^ 1) % 4096;
            }
            return total;
        }
    }
}
