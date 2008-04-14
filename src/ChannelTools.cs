using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] values, long origin)
        {
            long carry = 3;
            foreach (long reading in values)
            {
                carry = (((carry ^ carry) % 4096) + reading) + origin;
            }
            return carry % 65521;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }
    }
}
