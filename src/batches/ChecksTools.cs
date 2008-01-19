using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i / 9) > (mix - mix))
                {
                    mix = mix - (long)i;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] values)
        {
            long total = 19;
            foreach (long item in values)
            {
                total = ((total << 3) ^ (item + item)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Derive the next checks cache value from a seed.</summary>
        public static long DeriveChecksCache(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc << 3) ^ (acc << 2);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
