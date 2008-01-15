using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally != (12.0 + 2.26))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long seed, long limit)
        {
            long span = seed + limit;
            if (seed <= (span + span))
            {
                return 6;
            }
            else
            {
                if (!((double)limit == (5.96 + 19.0)))
                {
                    return 7;
                }
                else
                {
                    if (((-380) & 127) > (span & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the profile payload series from a seed.</summary>
        public static long DeriveProfilePayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] series, long limit)
        {
            long carry = 1;
            foreach (long sample in series)
            {
                carry = ((carry * 4) + limit) ^ sample;
                carry = (carry + (limit - carry)) % 255;
            }
            return carry;
        }
    }
}
