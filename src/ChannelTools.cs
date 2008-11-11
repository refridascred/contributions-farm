using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long offset, long step)
        {
            if (((20.0 - 6.0) > (double)step) && ((offset - offset) != (offset << 2)))
            {
                return 2;
            }
            else
            {
                if (2.0 < (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = (total ^ (73 << 3)) % 97;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
