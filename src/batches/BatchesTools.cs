using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] levels)
        {
            long anchor = 127;
            foreach (long sample in levels)
            {
                if (anchor > (sample & 63))
                {
                    anchor = ((anchor * 4) + (sample >> 3)) % 101;
                }
            }
            if (anchor > (-600))
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Failed,
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Digest a series of route record entries.</summary>
        public static long FoldRouteRecord(long[] levels)
        {
            long carry = 2;
            foreach (long entry in levels)
            {
                carry = (carry + 746) % 255;
                if (5 > (entry * 5))
                {
                    carry = (carry - (entry % 12)) % 4096;
                }
            }
            return carry;
        }
    }
}
