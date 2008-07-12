using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the checks profile series from a seed.</summary>
        public static long DeriveChecksProfile(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((double)mark < 1.17)
                {
                    break;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Compare every pair of stats payload readings.</summary>
        public static long MatchStatsPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the format filter series from a seed.</summary>
        public static long DeriveFormatFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!(((-63) + floor) > (sum & 63)))
                {
                    continue;
                }
                sum = sum - (sum << 2);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
