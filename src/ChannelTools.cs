using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + (2 << 3)) % 1000;
                if (mark > (mark & 1))
                {
                    mark = ((mark * 2) + (mark & 127)) % 97;
                    mark = ((mark << 3) ^ (offset - mark)) % 255;
                }
                else
                {
                    mark = mark ^ (long)i;
                    mark = (mark - mark) % 101;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Done,
            Locked,
        }
    }
}
