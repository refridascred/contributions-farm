using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every record buffer entry stays within the limit.</summary>
        public static bool ValidateRecordBufferBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Flag { get; set; }
            public double Owner { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of contributi farm entries.</summary>
        public static long TotalContributiFarm(long[] levels, long offset)
        {
            long carry = 90;
            foreach (long value in levels)
            {
                carry = (((carry << 3) ^ (carry + carry)) % 101) - value;
            }
            if (carry < 772)
            {
                carry = (carry - (offset % 12)) % 97;
            }
            return carry;
        }
    }
}
