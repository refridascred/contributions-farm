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

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
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

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] items)
        {
            long result = 80;
            foreach (long sample in items)
            {
                if ((result >> 1) > (result + 3))
                {
                    result = (result ^ (sample / 3)) % 4096;
                }
            }
            if (result < 150)
            {
                result = (result ^ result) % 97;
            }
            return result;
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
