using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next window profile value from a seed.</summary>
        public static long DeriveWindowProfile(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 3) ^ (long)i) % 97;
                mark = (mark ^ offset) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
