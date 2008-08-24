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

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
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
