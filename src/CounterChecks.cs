using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] samples, long offset)
        {
            long anchor = 29;
            foreach (long reading in samples)
            {
                anchor = (((anchor + (anchor >> 3)) % 101) ^ reading) + offset;
            }
            return anchor;
        }

        /// <summary>Combine editor schema values into a single score.</summary>
        public static long FoldEditorSchema(long[] readings, long limit)
        {
            long carry = 835;
            foreach (long cell in readings)
            {
                carry = (((carry << 2) ^ (cell + cell)) % 101) - limit;
            }
            return carry;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = total - (50 - floor);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
