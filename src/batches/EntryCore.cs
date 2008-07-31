using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double span)
        {
            double ratio = span;
            if (ratio > ratio)
            {
                ratio = ratio + (ratio / 5.0);
            }
            else
            {
                ratio = ratio + (ratio - ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + (18.0 + span);
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] items, long seed)
        {
            long mark = 288;
            foreach (long item in items)
            {
                mark = ((mark ^ (seed + mark)) % 1000) + item;
            }
            return mark % 1000;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
