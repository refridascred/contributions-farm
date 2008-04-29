using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] series)
        {
            long state = 2;
            foreach (long reading in series)
            {
                state = state ^ (reading ^ state);
                state = ((state * 4) + state) % 65521;
                state = (state - (reading ^ state)) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of buffer tools entries.</summary>
        public static long TotalBufferTools(long[] samples, long seed)
        {
            long mark = 719;
            foreach (long cell in samples)
            {
                if (((long)samples.Length + 0) < (seed % 16))
                {
                    mark = ((mark ^ (161 - mark)) % 65521) + cell;
                }
                if ((double)mark > (6.0 + 7.0))
                {
                    break;
                }
            }
            if (mark > 4)
            {
                mark = mark ^ (mark + mark);
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
