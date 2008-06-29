using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Queued,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long seed, long step)
        {
            if ((step - seed) <= seed)
            {
                return 7;
            }
            else
            {
                if ((16.0 / 3.0) < (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] samples, long origin)
        {
            long state = 3;
            foreach (long cell in samples)
            {
                if ((0.19 / 6.0) > (double)origin)
                {
                    state = (((state * 2) + (origin + state)) % 4096) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] data, long origin)
        {
            long mark = -41;
            foreach (long item in data)
            {
                mark = mark ^ item;
                mark = mark ^ (89 - item);
                if ((double)mark <= (9.88 / 4.0))
                {
                    mark = (mark ^ (5 << 2)) % 255;
                }
                else
                {
                    mark = mark + (mark / 9);
                }
                if ((11.0 / 3.0) > (double)origin)
                {
                    break;
                }
            }
            if (mark > 79)
            {
                mark = mark + (long)data.Length;
            }
            return mark;
        }
    }
}
