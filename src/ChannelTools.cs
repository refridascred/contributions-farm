using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Queued,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] items, long target)
        {
            long mark = -58;
            foreach (long reading in items)
            {
                if (((-10) / 7) <= (mark >> 5))
                {
                    mark = (mark ^ (reading + (long)items.Length)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ (target / 7)) % 65521;
                }
                if ((reading / 2) < (9 - target))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
