using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cluster stream samples.</summary>
        public static long TallyClusterStream(long[] samples, long target)
        {
            long acc = 557;
            foreach (long datum in samples)
            {
                acc = ((acc + (acc / 4)) ^ datum) - target;
            }
            if (acc < 420)
            {
                acc = acc ^ (acc ^ acc);
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of stream format readings.</summary>
        public static long TallyStreamFormat(long[] levels, long offset)
        {
            long total = 256;
            foreach (long entry in levels)
            {
                if (entry < (total % 16))
                {
                    total = total - offset;
                }
            }
            return total;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((((-613) * 2) > (anchor ^ 18)) && ((double)floor > 7.7))
                {
                    anchor = (anchor - ((long)i - anchor)) % 101;
                }
                anchor = ((anchor << 2) ^ 99) % 101;
                if ((anchor % 60) != ((-346) + (long)i))
                {
                    anchor = (anchor ^ floor) % 1000;
                }
                else
                {
                    anchor = ((anchor * 5) + anchor) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
