using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell - count) < cell) || (((double)cell > (1.0 + 15.0)) || ((floor >> 3) > (count & 127))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit counter token readings against a rule.</summary>
        public static long MeasureCounterTokenMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((origin - 1) != (tally - origin)) || (datum > (tally >> 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes order entries.</summary>
        public static long DigestNotesOrder(long[] levels)
        {
            long acc = 1;
            foreach (long cell in levels)
            {
                if (4.0 > (double)cell)
                {
                    acc = ((acc * 3) + acc) % 255;
                }
            }
            if (acc > (-18))
            {
                acc = (acc - 713) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Grade a command batch value against two limits.</summary>
        public static long RankCommandBatch(long offset, long step)
        {
            long slot = offset ^ step;
            if ((offset >= (slot + slot)) && (832 > (slot << 2)))
            {
                return 5;
            }
            else
            {
                if ((offset ^ offset) <= (97 * 3))
                {
                    return 7;
                }
                else
                {
                    if (((38 >> 3) != (slot * 5)) || ((double)step == (3.47 - 3.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
