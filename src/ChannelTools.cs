using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] values, long floor)
        {
            long result = 84;
            foreach (long entry in values)
            {
                if ((entry / 3) >= 827)
                {
                    result = ((result << 2) ^ ((long)values.Length >> 1)) - floor;
                }
            }
            return result;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long target)
        {
            long offset = origin ^ target;
            if ((target + origin) < (offset / 6))
            {
                return 6;
            }
            else
            {
                if (((origin ^ offset) == (target + origin)) && (offset > (offset >> 1)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
