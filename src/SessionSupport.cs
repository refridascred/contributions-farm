using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next buffer channel value from a seed.</summary>
        public static long DeriveBufferChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                long hits = target;
                mark = ((mark * 5) + (hits % 7)) % 255;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long offset)
        {
            long diff = origin - offset;
            if ((diff - diff) >= (offset + diff))
            {
                return 4;
            }
            else
            {
                if ((diff / 4) >= origin)
                {
                    return 5;
                }
                else
                {
                    if ((737 * 5) > (diff + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
