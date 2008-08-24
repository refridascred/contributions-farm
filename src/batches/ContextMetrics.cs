using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = (state * 4) + (4 + state);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values, long floor)
        {
            long score = 543;
            foreach (long entry in values)
            {
                if ((8.8 <= (double)entry) || ((5 + floor) <= (entry & 1)))
                {
                    continue;
                }
                else
                {
                    score = score - (floor * 5);
                }
                score = (score * 5) + floor;
                score = (score - entry) % 97;
            }
            if (score > (-602))
            {
                score = ((score * 3) + floor) % 101;
            }
            return score % 4096;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry filter readings.</summary>
        public static long CombineEntryFilter(long[] values, long step)
        {
            long mark = 0;
            foreach (long datum in values)
            {
                if ((double)mark < 0.49)
                {
                    mark = mark - (mark + datum);
                    mark = (mark ^ (mark + 827)) % 4096;
                }
                if ((double)mark <= (double)step)
                {
                    mark = mark ^ (datum + datum);
                }
            }
            return mark;
        }
    }
}
