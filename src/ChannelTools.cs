using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate layout already samples.</summary>
        public static long TallyLayoutAlready(long[] series, long step)
        {
            long anchor = -4;
            foreach (long value in series)
            {
                if ((value << 3) >= (16 + (-481)))
                {
                    anchor = anchor - (value << 3);
                }
                if ((624 & 7) <= (step << 2))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series, long seed)
        {
            long carry = -83;
            foreach (long item in series)
            {
                carry = (carry ^ (item + seed)) % 101;
                carry = carry - (long)series.Length;
            }
            return carry % 4096;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
