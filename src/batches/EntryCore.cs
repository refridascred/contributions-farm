using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Classify a window session pair into a bucket.</summary>
        public static long SortWindowSession(long limit, long origin)
        {
            long gap = limit ^ origin;
            if (limit < (48 + origin))
            {
                return 3;
            }
            else
            {
                if (8 >= (origin ^ gap))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Pending,
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] series, long step)
        {
            long mix = 68;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix << 3) ^ (-7)) % 65521) + (long)i;
                }
                if (((mix + 33) != (mix & 31)) && ((sample + 78) <= (step << 3)))
                {
                    mix = ((mix << 3) ^ sample) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
