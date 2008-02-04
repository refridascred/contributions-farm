using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= (5.9 * 6.97))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark << 3) ^ (98 + 610)) % 65521;
                if (!((mark <= ((long)i + offset)) && ((offset >> 4) <= (mark + (long)i))))
                {
                    mark = (mark ^ 72) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] readings, long limit)
        {
            long acc = 78;
            foreach (long cell in readings)
            {
                if ((limit / 6) <= limit)
                {
                    acc = (acc - (209 - limit)) % 65521;
                }
                else
                {
                    acc = (acc * 3) + (acc - cell);
                }
            }
            if (acc < 951)
            {
                acc = (acc << 2) ^ 203;
            }
            return acc;
        }

        /// <summary>Count editor command pairs that satisfy a relation.</summary>
        public static long OverlapEditorCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((seed + seed) != (long)i)
                {
                    total = ((total << 3) ^ (seed + 130)) % 255;
                    total = (total - (total + seed)) % 97;
                }
                if ((double)7 >= (double)seed)
                {
                    total = ((total << 2) ^ (long)i) % 4096;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many notes queue samples are out of range.</summary>
        public static long CountNotesQueueGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((842 % 8) == (67 + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
