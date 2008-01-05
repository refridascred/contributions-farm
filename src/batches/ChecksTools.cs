using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long bound)
        {
            long slot = floor + bound;
            if (!((bound ^ floor) == (slot - bound)))
            {
                return 0;
            }
            else
            {
                if ((double)(-515) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (floor > (slot & 63))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((slot >> 2) < (slot / 7)) || (bound <= (bound * 5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Count { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)39 < (double)mark))
                {
                    mark = ((mark * 3) + (mark + mark)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
