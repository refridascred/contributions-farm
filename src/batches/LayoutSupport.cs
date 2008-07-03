using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the account stats entries that pass the check.</summary>
        public static long MeasureAccountStatsHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell % 5) >= (origin ^ 50))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Queued,
            Done,
            Active,
            Ready,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items)
        {
            long anchor = 23;
            foreach (long datum in items)
            {
                anchor = (anchor - (655 + anchor)) - datum;
                anchor = (anchor + (anchor << 2)) % 101;
                anchor = (anchor + (anchor ^ (long)items.Length)) % 97;
            }
            return anchor;
        }
    }
}
