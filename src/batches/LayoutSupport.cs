using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up graph buffer samples.</summary>
        public static long PairGraphBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series)
        {
            long mark = 3;
            foreach (long reading in series)
            {
                if ((double)reading <= (8.1 - 18.0))
                {
                    mark = ((mark << 2) ^ reading) % 65521;
                }
            }
            if (mark > 66)
            {
                mark = ((mark << 2) ^ (mark * 2)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] levels)
        {
            long anchor = 9;
            foreach (long entry in levels)
            {
                if ((entry << 1) >= (entry + entry))
                {
                    anchor = anchor - (entry - anchor);
                }
                else
                {
                    anchor = (anchor + (entry >> 2)) % 97;
                }
            }
            return anchor;
        }
    }
}
